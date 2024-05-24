using Company.LeaveManagement.MVC.Contracts;
using Company.LeaveManagement.MVC.Models;
using Company.LeaveManagement.MVC.Services.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Company.LeaveManagement.MVC.Controllers
{
    public class LeaveTypesController : Controller
    {
        private readonly ILeaveTypeService _leaveTypeService;

        public LeaveTypesController(ILeaveTypeService leaveTypeService)
        {
            _leaveTypeService = leaveTypeService;
        }
        public async Task<ActionResult> Index()
        {
            var model =await _leaveTypeService.GetLeaveTypes();
            return View(model);
        }

        public async Task<ActionResult> Details(int id)
        {
            return View();
        }

        public async Task<ActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CreateLeaveTypeVM leaveType)
        {
            try
            {
                var response = await _leaveTypeService.CreateLeaveType(leaveType);
                if (response.Success)
                {
                    return RedirectToAction(actionName: nameof(Index));
                }
                ModelState.AddModelError("", errorMessage: response.ValidationErrors);
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            return View(leaveType);

        }

        public async Task<ActionResult> Edit(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public async Task<ActionResult> Delete(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
