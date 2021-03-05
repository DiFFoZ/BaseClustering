﻿using Rocket.API;

namespace Pustalorc.Plugins.BaseClustering.Config
{
    public sealed class BaseClusteringPluginConfiguration : IRocketPluginConfiguration
    {
        public bool VerboseLogging;
        public float MaxDistanceBetweenStructures;
        public float MaxDistanceToConsiderPartOfBase;
        public float DestroyIntegrityCheckDistance;

        public void LoadDefaults()
        {
            VerboseLogging = false;
            MaxDistanceBetweenStructures = 6.1f;
            MaxDistanceToConsiderPartOfBase = 10f;
            DestroyIntegrityCheckDistance = 20f;
        }
    }
}