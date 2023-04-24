using RestoranFinalyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranFinalyProject.ViewModels
{
    public class BTn6
    {
        public Garson? garson { get; set; }
        public float? hesab { get; set; }
        public bool? status { get; set; } = true;

        private static BTn6? _instance = null;

        private BTn6()
        {

        }

        public static BTn6 GetInstance()
        {
            if (_instance == null)
                _instance = new BTn6();
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
