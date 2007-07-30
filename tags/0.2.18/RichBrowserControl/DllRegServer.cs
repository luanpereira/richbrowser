using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

/// <summary>
/// TODO
/// </summary>
public class DllRegServer
{

    private string m_sDllFile;
    private static ModuleBuilder s_mb;
    private Type m_tDllReg;

    /// <summary>
    /// TODO
    /// </summary>
    /// <param name="dllFile"></param>
    public DllRegServer(string dllFile)
    {
        m_sDllFile = dllFile;
        CreateDllRegType();
    }

    /// <summary>
    /// TODO
    /// </summary>
    public void Register()
    {
        InternalRegServer(false);
    }

    /// <summary>
    /// TODO
    /// </summary>
    public void UnRegister()
    {
        InternalRegServer(true);
    }

    private void InternalRegServer(bool fUnreg)
    {
        string sMemberName = fUnreg ? "DllUnregisterServer" : "DllRegisterServer";

        int hr = (int)m_tDllReg.InvokeMember(sMemberName, BindingFlags.InvokeMethod, null,
                                              Activator.CreateInstance(m_tDllReg), null);
        if (hr != 0)
            Marshal.ThrowExceptionForHR(hr);
    }

    private void CreateDllRegType()
    {
        if (s_mb == null)
        {
            // Create dynamic assembly    
            AssemblyName an = new AssemblyName();
            an.Name = "DllRegServerAssembly" + Guid.NewGuid().ToString("N");
            AssemblyBuilder ab = AppDomain.CurrentDomain.DefineDynamicAssembly(an, AssemblyBuilderAccess.Run);

            // Add module to assembly
            s_mb = ab.DefineDynamicModule("DllRegServerModule");
        }

        // Add class to module
        TypeBuilder tb = s_mb.DefineType("DllRegServerClass" + Guid.NewGuid().ToString("N"));

        MethodBuilder meb;

        // Add PInvoke methods to class
        meb = tb.DefinePInvokeMethod("DllRegisterServer", m_sDllFile,
          MethodAttributes.Public | MethodAttributes.Static | MethodAttributes.PinvokeImpl,
          CallingConventions.Standard, typeof(int), null, CallingConvention.StdCall, CharSet.Auto);

        // Apply preservesig metadata attribute so we can handle return HRESULT ourselves
        meb.SetImplementationFlags(MethodImplAttributes.PreserveSig | meb.GetMethodImplementationFlags());

        meb = tb.DefinePInvokeMethod("DllUnregisterServer", m_sDllFile,
          MethodAttributes.Public | MethodAttributes.Static | MethodAttributes.PinvokeImpl,
          CallingConventions.Standard, typeof(int), null, CallingConvention.StdCall, CharSet.Auto);

        // Apply preservesig metadata attribute so we can handle return HRESULT ourselves
        meb.SetImplementationFlags(MethodImplAttributes.PreserveSig | meb.GetMethodImplementationFlags());

        // Create the type
        m_tDllReg = tb.CreateType();
    }

}
