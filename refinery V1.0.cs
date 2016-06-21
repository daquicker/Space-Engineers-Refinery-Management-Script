void OreInsertAttempt(float orePos, int chunkSize, List<IMyRefinery> emptyRefs, IMyInventory oreContainerInv)
{
	for (int i = 0; i < emptyRefs.Count; i++)
	{
		oreContainerInv.TransferItemTo(emptyRefs[i].GetInventory(0), (int)orePos, null, true, chunkSize);
	}
}

void Main()
{
	int gravelTres = 10000;
	int ironTres = 500000;
	int siliconTres = 25000;
	int nickelTres = 50000;
	int cobaltTres = 50000;
	int silverTres = 15000;
	int goldTres = 15000;
	int uraniumTres = 20000;
	int magnesiumTres = 5000;
	int platinumTres = 2000;

	int stoneChunk = 5000;
	int ironChunk = 5000;
	int siliconChunk = 1000;
	int nickelChunk = 500;
	int cobaltChunk = 500;
	int silverChunk = 300;
	int goldChunk = 300;
	int uraniumChunk = 300;
	int magnesiumChunk = 300;
	int platinumChunk = 300;

	List<IMyTerminalBlock> refineries = new List<IMyTerminalBlock>();
	GridTerminalSystem.GetBlocksOfType<IMyRefinery>(refineries);

	List<IMyRefinery> emptyRefs = new List<IMyRefinery> { };

	List<IMyTerminalBlock> containers = new List<IMyTerminalBlock>();
	GridTerminalSystem.GetBlocksOfType<IMyCargoContainer>(containers);

	List<IMyTerminalBlock> reactors = new List<IMyTerminalBlock>();
	GridTerminalSystem.GetBlocksOfType<IMyReactor>(reactors);

	IMyCargoContainer ingotContainer = GridTerminalSystem.GetBlockWithName("Ingots") as IMyCargoContainer;
	IMyInventory ingotContainerInv = ingotContainer.GetInventory(0);
	var ingotContainerItems = ingotContainerInv.GetItems();

	IMyCargoContainer oreContainer = GridTerminalSystem.GetBlockWithName("Ores") as IMyCargoContainer;
	IMyInventory oreContainerInv = oreContainer.GetInventory(0);
	var oreContainerItems = oreContainerInv.GetItems();

	List<float> ingList = new List<float> { };

	List<float> gravelIng = new List<float> { 0, 1000 };
	List<float> ironIng = new List<float> { 0, 1000 };
	List<float> siliconIng = new List<float> { 0, 1000 };
	List<float> nickelIng = new List<float> { 0, 1000 };
	List<float> cobaltIng = new List<float> { 0, 1000 };
	List<float> silverIng = new List<float> { 0, 1000 };
	List<float> goldIng = new List<float> { 0, 1000 };
	List<float> uraniumIng = new List<float> { 0, 1000 };
	List<float> magnesiumIng = new List<float> { 0, 1000 };
	List<float> platinumIng = new List<float> { 0, 1000 };

	List<float> stoneOre = new List<float> { 0, 1000 };
	List<float> ironOre = new List<float> { 0, 1000 };
	List<float> siliconOre = new List<float> { 0, 1000 };
	List<float> nickelOre = new List<float> { 0, 1000 };
	List<float> cobaltOre = new List<float> { 0, 1000 };
	List<float> silverOre = new List<float> { 0, 1000 };
	List<float> goldOre = new List<float> { 0, 1000 };
	List<float> uraniumOre = new List<float> { 0, 1000 };
	List<float> magnesiumOre = new List<float> { 0, 1000 };
	List<float> platinumOre = new List<float> { 0, 1000 };

	for (int i = 0; i < ingotContainerItems.Count; i++)
	{
		string currentIngStr = ingotContainerItems[i].Content.SubtypeName;
		if (currentIngStr.Contains("Gravel"))
		{
			gravelIng[0] = (float)ingotContainerItems[i].Amount;
			gravelIng[1] = i;
		}
		else if (currentIngStr.Contains("Iron"))
		{
			ironIng[0] = (float)ingotContainerItems[i].Amount;
			ironIng[1] = i;
		}
		else if (currentIngStr.Contains("Silicon"))
		{
			siliconIng[0] = (float)ingotContainerItems[i].Amount;
			siliconIng[1] = i;
		}
		else if (currentIngStr.Contains("Nickel"))
		{
			nickelIng[0] = (float)ingotContainerItems[i].Amount;
			nickelIng[1] = i;
		}
		else if (currentIngStr.Contains("Cobalt"))
		{
			cobaltIng[0] = (float)ingotContainerItems[i].Amount;
			cobaltIng[1] = i;
		}
		else if (currentIngStr.Contains("Silver"))
		{
			silverIng[0] = (float)ingotContainerItems[i].Amount;
			silverIng[1] = i;
		}
		else if (currentIngStr.Contains("Gold"))
		{
			goldIng[0] = (float)ingotContainerItems[i].Amount;
			goldIng[1] = i;
		}
		else if (currentIngStr.Contains("Uranium"))
		{
			uraniumIng[0] = (float)ingotContainerItems[i].Amount;
			uraniumIng[1] = i;
		}
		else if (currentIngStr.Contains("Magnesium"))
		{
			magnesiumIng[0] = (float)ingotContainerItems[i].Amount;
			magnesiumIng[1] = i;
		}
		else if (currentIngStr.Contains("Platinum"))
		{
			platinumIng[0] = (float)ingotContainerItems[i].Amount;
			platinumIng[1] = i;
		}
	}

	for (int i = 0; i < reactors.Count; i++)
	{
		var currentReactorItems = reactors[i].GetInventory(0).GetItems();
		for (int j = 0; j < currentReactorItems.Count; j++)
		{
			uraniumIng[0] += (float)currentReactorItems[j].Amount;
		}
	}

	for (int i = 0; i < oreContainerItems.Count; i++)
	{
		string currentOreStr = oreContainerItems[i].Content.SubtypeName;
		if (currentOreStr.Contains("Stone"))
		{
			stoneOre[0] = (float)oreContainerItems[i].Amount;
			stoneOre[1] = i;
		}
		else if (currentOreStr.Contains("Iron"))
		{
			ironOre[0] = (float)oreContainerItems[i].Amount;
			ironOre[1] = i;
		}
		else if (currentOreStr.Contains("Silicon"))
		{
			siliconOre[0] = (float)oreContainerItems[i].Amount;
			siliconOre[1] = i;
		}
		else if (currentOreStr.Contains("Nickel"))
		{
			nickelOre[0] = (float)oreContainerItems[i].Amount;
			nickelOre[1] = i;
		}
		else if (currentOreStr.Contains("Cobalt"))
		{
			cobaltOre[0] = (float)oreContainerItems[i].Amount;
			cobaltOre[1] = i;
		}
		else if (currentOreStr.Contains("Silver"))
		{
			silverOre[0] = (float)oreContainerItems[i].Amount;
			silverOre[1] = i;
		}
		else if (currentOreStr.Contains("Gold"))
		{
			goldOre[0] = (float)oreContainerItems[i].Amount;
			goldOre[1] = i;
		}
		else if (currentOreStr.Contains("Uranium"))
		{
			uraniumOre[0] = (float)oreContainerItems[i].Amount;
			uraniumOre[1] = i;
		}
		else if (currentOreStr.Contains("Magnesium"))
		{
			magnesiumOre[0] = (float)oreContainerItems[i].Amount;
			magnesiumOre[1] = i;
		}
		else if (currentOreStr.Contains("Platinum"))
		{
			platinumOre[0] = (float)oreContainerItems[i].Amount;
			platinumOre[1] = i;
		}
	}

	for (int i = 0; i < refineries.Count; i++)
	{
		if (refineries[i].GetInventory(0).GetItems().Count < 1)
		{
			emptyRefs.Add(refineries[i] as IMyRefinery);
		}
	}

	if (platinumIng[0] < platinumTres && platinumOre[0] > (emptyRefs.Count * platinumChunk))
	{
		OreInsertAttempt(platinumOre[1], platinumChunk, emptyRefs, oreContainerInv);
	}
	else if (silverIng[0] < silverTres && silverOre[0] > (emptyRefs.Count * silverChunk))
	{
		OreInsertAttempt(silverOre[1], silverChunk, emptyRefs, oreContainerInv);
	}
	else if (goldIng[0] < goldTres && goldOre[0] > (emptyRefs.Count * goldChunk))
	{
		OreInsertAttempt(goldOre[1], goldChunk, emptyRefs, oreContainerInv);
	}
	else if (siliconIng[0] < siliconTres && siliconOre[0] > (emptyRefs.Count * siliconChunk))
	{
		OreInsertAttempt(siliconOre[1], siliconChunk, emptyRefs, oreContainerInv);
	}
	else if (magnesiumIng[0] < magnesiumTres && magnesiumOre[0] > (emptyRefs.Count * magnesiumChunk))
	{
		OreInsertAttempt(magnesiumOre[1], magnesiumChunk, emptyRefs, oreContainerInv);
	}
	else if (gravelIng[0] < gravelTres && stoneOre[0] > (emptyRefs.Count * stoneChunk))
	{
		OreInsertAttempt(stoneOre[1], stoneChunk, emptyRefs, oreContainerInv);
	}
	else if (uraniumIng[0] < uraniumTres && uraniumOre[0] > (emptyRefs.Count * uraniumChunk))
	{
		OreInsertAttempt(uraniumOre[1], uraniumChunk, emptyRefs, oreContainerInv);
	}

	emptyRefs.Clear();
	for (int i = 0; i < refineries.Count; i++)
	{
		if (refineries[i].GetInventory(0).GetItems().Count < 1)
		{
			emptyRefs.Add(refineries[i] as IMyRefinery);
		}
	}

	if (cobaltIng[0] < cobaltTres && cobaltOre[0] > (emptyRefs.Count * cobaltChunk))
	{
		OreInsertAttempt(cobaltOre[1], cobaltChunk, emptyRefs, oreContainerInv);
	}
	else if (nickelIng[0] < nickelTres && nickelOre[0] > (emptyRefs.Count * nickelChunk))
	{
		OreInsertAttempt(nickelOre[1], nickelChunk, emptyRefs, oreContainerInv);
	}
	else if (ironIng[0] < ironTres && ironOre[0] > (emptyRefs.Count * ironChunk))
	{
		OreInsertAttempt(ironOre[1], ironChunk, emptyRefs, oreContainerInv);
	}
}