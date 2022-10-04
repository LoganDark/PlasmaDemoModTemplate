# Plasma Demo Mod Template

Visual Studio 2019 template for making Plasma Demo mods

## Usage

1. Install [UnityModManager](https://github.com/newman55/unity-mod-manager).
2. Install Cit's config for Plasma:

  ```xml
  	<GameInfo Name="Plasma Demo">
  		<Folder>Plasma Demo</Folder>
  		<ModsDirectory>Mods</ModsDirectory>
  		<ModInfo>Info.json</ModInfo>
  		<GameExe>Plasma.exe</GameExe>
  		<EntryPoint>[UnityEngine.UI.dll]UnityEngine.EventSystems.EventSystem.cctor:After</EntryPoint>
  		<StartingPoint>[Assembly-CSharp.dll]Visor.Visor.Awake:Before</StartingPoint>
  		<UIStartingPoint>[Assembly-CSharp.dll]Visor.Visor.Awake:After</UIStartingPoint>
  		<GameVersionPoint>[Assembly-CSharp.dll]Plasma.localBuild</GameVersionPoint>
  		<Comment>created by Cit#7971 before release</Comment>
  	</GameInfo>
  ```

3. Open UnityModManager.exe, select Plasma Demo in the dropdown, select the
   "Assembly" method, and select "Install".

4. Drag a zip of this repository to your
   `Documents/Visual Studio <whatever>/Templates/ProjectTemplates` directory.

5. Make a new Visual Studio project using the "Plasma Demo Mod Template"
   template, rather than Class Library or .NET Framework or similar.

6. (Optionally) open the project settings, go to Build Events, and change the
   path to Plasma Demo (in the last command) to line up with yours, if the auto
   installation is not working properly.

7. Make sure to use the debug build if you want hot-reload!

More detailed steps coming eventually.
