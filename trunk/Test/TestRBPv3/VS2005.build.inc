<?xml version="1.0" encoding="euc-kr"?>
<project name="VS2005" default="main">

<!--

VS2005Settigns.build.inc example
====
<?xml version="1.0" encoding="euc-kr"?>
<project name="VS2005Settings" default="main">

	<property name="devenv.dir" value="C:\Program Files\Microsoft Visual Studio 8\Common7\IDE" />
	<property name="devenv.solution.file" value="App/App.sln"/>
	<property name="devenv.config" value="Debug"/>
	<property name="devenv.log.file" value="build.log"/>
	
</project>
====

-->

	<property name="settings.file" value="VS2005Settings.build.inc"/>
	<include buildfile="${settings.file}"/>
		
	<target name="prepare">
		<fail unless="${property::exists('devenv.dir')}">'devenv.dir' Property not set.</fail>
		<fail unless="${property::exists('devenv.solution.file')}">'devenv.solution.file' Property not set.</fail>
		<fail unless="${property::exists('devenv.config')}">'devenv.config' Property not set.</fail>
		<fail unless="${property::exists('devenv.log.file')}">'devenv.log.file' Property not set.</fail>
	</target>

	<target name="build" depends="prepare">
		<echo message="Building..."/>
		<exec failonerror="true" basedir="${devenv.dir}"
			program="devenv.com" commandline="${devenv.solution.file} /Build ${devenv.config} /out ${devenv.log.file}" />
	</target>
	
	<target name="rebuild" depends="prepare">
		<echo message="Rebuilding..."/>
		<exec failonerror="true" basedir="${devenv.dir}"
			program="devenv.com" commandline="${devenv.solution.file} /Rebuild ${devenv.config} /out ${devenv.log.file}" />
	</target>
	
	<target name="main" depends="rebuild">
	</target>
	
</project>
