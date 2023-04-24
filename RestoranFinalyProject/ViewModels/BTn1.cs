using RestoranFinalyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranFinalyProject.ViewModels
{
    public class BTn1
    {
        public Garson? garson { get; set; }
        public float? hesab { get; set; }
        public bool? status { get; set; } = true;

        private static BTn1? _instance = null;

        private BTn1()
        {

        }

        public static BTn1 GetInstance()
        {
            if (_instance == null)
                _instance = new BTn1();
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
