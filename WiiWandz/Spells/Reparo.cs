﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WiiWandz.Strokes;
using WiiWandz.Ifttt;

namespace WiiWandz.Spells
{
	class Reparo : CloudBitSpell
	{
        public Reparo(double confidence)
            : base(confidence)
        {
            this.minConfidence = 0.999;
            this.minPercentOfTotalBetweenStartAndEndPoints = 30;
            this.maxPercentOfTotalBetweenStartAndEndPoints = 70;
            this.acceptableDirectionsFromStartToEndPoint.Add(StrokeDirection.UpToTheRight);
            this.acceptableDirectionsFromStartToEndPoint.Add(StrokeDirection.Right);
            this.acceptableDirectionsFromStartToEndPoint.Add(StrokeDirection.DownToTheRight);
        }

        public Reparo(String device, String authorization, int voltage, int duration, String iftttKey, String iftttEvent)
            : base(device, authorization, voltage, duration, iftttKey, iftttEvent)
		{
            List<StrokeDirection> directions = new List<StrokeDirection>();
            directions.Add(StrokeDirection.UpToTheLeft);
            directions.Add(StrokeDirection.Up);
            directions.Add(StrokeDirection.UpToTheRight);
            directions.Add(StrokeDirection.Right);
            directions.Add(StrokeDirection.DownToTheRight);
            directions.Add(StrokeDirection.Down);
            directions.Add(StrokeDirection.DownToTheLeft);
            directions.Add(StrokeDirection.Left);
            directions.Add(StrokeDirection.UpToTheLeft);
            directions.Add(StrokeDirection.Up);
            directions.Add(StrokeDirection.UpToTheRight);
            directions.Add(StrokeDirection.Right);
            this.strokesForSpell.Add(directions);

            directions = new List<StrokeDirection>();
            directions.Add(StrokeDirection.UpToTheLeft);
            directions.Add(StrokeDirection.UpToTheRight);
            directions.Add(StrokeDirection.Right);
            directions.Add(StrokeDirection.DownToTheRight);
            directions.Add(StrokeDirection.DownToTheLeft);
            directions.Add(StrokeDirection.Left);
            directions.Add(StrokeDirection.UpToTheLeft);
            directions.Add(StrokeDirection.UpToTheRight);
            directions.Add(StrokeDirection.Right);
            this.strokesForSpell.Add(directions);

        }
	}
}
