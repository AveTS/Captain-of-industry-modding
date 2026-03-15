using Mafi;
using Mafi.Base;
using Mafi.Collections;
using Mafi.Core;
using Mafi.Core.Mods;

namespace ExampleMod;

public sealed class ExampleMod : DataOnlyMod {

	// Mod constructor will be called on mod loading.
	public ExampleMod(ModManifest manifest) : base(manifest) {
		// You can use Log class for logging. These will be written to the log file
		// and can be also displayed in the in-game console with command `also_log_to_console`.
		Log.Info("ExampleMod: constructed");

		// The manifest.RootDirectoryPath can be used to access mod files if needed
		// for later loading of additional content, that is not required on mod load.
	}


	public override void RegisterPrototypes(ProtoRegistrator registrator) {
		Log.Info("ExampleMod: registering prototypes");
		// Register all prototypes here.

		// Registers all products from this assembly. See ExampleModIds.Products.cs for examples.
		registrator.RegisterAllProducts();

		// Use data class registration to register other protos such as machines, recipes, etc.
		registrator.RegisterData<ExampleMachineData>();

		// Registers all research from this assembly. See ExampleResearchData.cs for examples.
		registrator.RegisterDataWithInterface<IResearchNodesData>();
	}

	public override void MigrateJsonConfig(VersionSlim savedVersion, Dict<string, object> savedValues) {

	}
}