using EduCavoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduCavoFinal.ViewModels
{
    public class VMErrorPage:VMBase
    {
        public ErrorPage Error { get; set; }
        public List<Categories> Categories { get; set; }

    }
}
