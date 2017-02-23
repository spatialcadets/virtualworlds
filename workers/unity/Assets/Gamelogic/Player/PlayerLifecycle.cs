﻿using Assets.Gamelogic.Core;
using Improbable.Core;
using Improbable.Unity;
using Improbable.Unity.Core;
using Improbable.Unity.Visualizer;
using UnityEngine;

namespace Assets.Gamelogic.Player
{
    [WorkerType(WorkerPlatform.UnityClient)]
    class PlayerLifecycle : MonoBehaviour
    {
		[Require] private ClientAuthorityCheck.Writer clientAuthorityCheck;
		
        private void OnApplicationQuit()
        {
            if (SpatialOS.IsConnected)
            {
                ClientPlayerSpawner.DeletePlayer();
            }
        }
    }
}
