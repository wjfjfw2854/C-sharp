using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppNo1.Models;
using WebAppNo1.ViewModels;

namespace WebAppNo1.Controllers
{
    
    public class IndividalController:Controller
    {
        private IIndividalRepories _iIndividalRepories;
        private IConptionRepories _iConptionRepories;
        private Ihwelcome _iHwelcome;
        public IndividalController(IIndividalRepories iIndividalRepories, IConptionRepories iConptionRepories,Ihwelcome ihwelcome)
        {
            _iIndividalRepories = iIndividalRepories;
            _iConptionRepories = iConptionRepories;
            _iHwelcome = ihwelcome;
        }
        public IActionResult index()
        {
            
            var vm = new IndividalViewModel() {
                Individals = _iIndividalRepories.getAllIndividal().ToList(),
                Conptions = _iConptionRepories.getAllAddress().ToList()
            };
            return View(vm);
        }

        public IActionResult hwelcome()
        {
            var vm = new HwelcomeVm() {
                welcomes = _iHwelcome.getHwelcomes().ToList()
            };
            return View(vm);
        }
    }
}
