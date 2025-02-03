Player notes:
	To avoid jittery/offputting hand movement, the player object should be in their own layer. 
	In this layer under edit->project settings->physics uncheck the player/player matrix node.
		
	Then within the player object->SteamVRObjects->LeftHand go to the Hand Physics (script) then double click the Hand collider prefab. 
	In the prefab editor add the parent node to the player layer as well. If prompted to add all children. Click yes.