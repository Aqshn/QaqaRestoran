using RestoranFinalyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranFinalyProject.ViewModels
{
    public class BTn5
    {
        public Garson? garson { get; set; }
        public float? hesab { get; set; }
        public bool? status { get; set; } = true;

        private static BTn5? _instance = null;

        private BTn5()
        {

        }

        public static BTn5 GetInstance()
        {
            if (_instance == null)
                _instance = new BTn5();
            return _instance;
        }
        public void Clear()
        {
            garson = null;
            hesab = null;
            status = true;
        }
    }
}
