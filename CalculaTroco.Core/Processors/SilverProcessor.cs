﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaTroco.Core.Processors {
    internal class SilverBarProcessor : AbstractProcessor {

        private string name = "Barras de Prata";
        private long[] silverBars = { 100000, 50000 };

        internal override long[] AvailableValues() {
            return this.silverBars;
        }

        internal override string GetName() {
            return this.name;
        }
    }
}
