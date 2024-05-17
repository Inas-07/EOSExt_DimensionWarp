﻿using ExtraObjectiveSetup.Utils;
using System.Collections.Generic;

namespace EOSExt.DimensionWarp.Definition
{
    public class PositionAndLookDir
    {
        public Vec3 Position { get; set; } = new();

        public int LookDir { get; set; } = 0;
    }

    public class OnWarp 
    {
        public bool WarpTeam_WarpAllWarpableBigPickupItems { get; set; } = true;

        public bool WarpRange_WarpDeployedSentryOutsideRange { get; set; } = true;

        public bool WarpItemsInZone_OnlyWarpWarpable { get; set; } = true;
    }

    public class DimensionWarpDefinition
    {
        public string WorldEventObjectFilter { get; set; } = string.Empty;

        public eDimensionIndex DimensionIndex { set; get; } = eDimensionIndex.Reality;

        public OnWarp OnWarp { get; set; } = new();

        public List<PositionAndLookDir> Locations { get; set; } = new();
    }
}
