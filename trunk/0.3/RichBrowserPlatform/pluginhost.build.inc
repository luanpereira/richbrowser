<?xml version="1.0" encoding="euc-kr"?>
<project name="pluginhost" default="main">

	<property name="pluginhost.name" value="${environment::get-variable('__PLUGINHOST_NAME')}" />
	<property name="output.dir" value="${path::get-full-path('..')}/${pluginhost.name}/bin/${environment::get-variable('__CONFIG_NAME')}"/>
	<property name="plugins.dir" value="${output.dir}/Plugins"/>

</project>
