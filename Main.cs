using System.Reflection;

using UnityModManagerNet;
using HarmonyLib;

namespace $safeprojectname$ {
#if DEBUG
	[EnableReloading]
#endif
	public static class Main {
		static Harmony harmony;

		public static bool Load(UnityModManager.ModEntry entry) {
			harmony = new Harmony(entry.Info.Id);

			entry.OnToggle = OnToggle;
#if DEBUG
			entry.OnUnload = OnUnload;
#endif

			return true;
		}

		static bool OnToggle(UnityModManager.ModEntry entry, bool active) {
			if (active) {
				harmony.PatchAll(Assembly.GetExecutingAssembly());
			} else {
				harmony.UnpatchAll(entry.Info.Id);
			}

			return true;
		}

#if DEBUG
		static bool OnUnload(UnityModManager.ModEntry entry) {
			return true;
		}
#endif

		// Add Harmony patches down here!
	}
}
