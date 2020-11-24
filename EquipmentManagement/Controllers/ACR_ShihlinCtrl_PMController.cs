using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EquipmentManagement.Data;
using EquipmentManagement.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EquipmentManagement.Controllers
{
    public class ACR_ShihlinCtrl_PMController : Controller
    {
        private readonly ApplicationDbContext context;

        public ACR_ShihlinCtrl_PMController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult> PreventiveMaintenance()
        {
            var fileuploadViewModel = await LoadAllFiles();
            ViewBag.Message = TempData["Message"];
            return View(fileuploadViewModel);
        }
        
        [HttpPost]
        public async Task<IActionResult> UploadToDatabase(List<IFormFile> files, string description)
        {
            foreach (var file in files)
            {
                var fileName = Path.GetFileNameWithoutExtension(file.FileName);
                var extension = Path.GetExtension(file.FileName);
                var fileModel = new ACR_ShihlinCtrl_FileOnDatabaseModelPM
                {
                    CreatedOn = DateTime.UtcNow,
                    FileType = file.ContentType,
                    Extension = extension,
                    Name = fileName,
                    Description = description
                };
                using (var dataStream = new MemoryStream())
                {
                    await file.CopyToAsync(dataStream);
                    fileModel.Data = dataStream.ToArray();
                }
                context.ACR_ShihlinCtrl_FileOnDatabasePM.Add(fileModel);
                context.SaveChanges();
            }
            TempData["Message"] = "File successfully uploaded to Database";
            return RedirectToAction("PreventiveMaintenance");
        }

        private async Task<ACR_ShihlinCtrl_FileUploadViewModelPM> LoadAllFiles()
        {
            var viewModel = new ACR_ShihlinCtrl_FileUploadViewModelPM();
            viewModel.ACR_ShihlinCtrl_FilesOnDatabasePM = await context.ACR_ShihlinCtrl_FileOnDatabasePM.ToListAsync();
            return viewModel;
        }

        public async Task<IActionResult> DownloadFileFromDatabase(int id)
        {

            var file = await context.ACR_ShihlinCtrl_FileOnDatabasePM.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (file == null) return null;
            return File(file.Data, file.FileType, file.Name + file.Extension);
        }

        public async Task<IActionResult> DeleteFileFromDatabase(int id)
        {

            var file = await context.ACR_ShihlinCtrl_FileOnDatabasePM.Where(x => x.Id == id).FirstOrDefaultAsync();
            context.ACR_ShihlinCtrl_FileOnDatabasePM.Remove(file);
            context.SaveChanges();
            TempData["Message"] = $"Removed {file.Name + file.Extension} successfully from Database.";
            return RedirectToAction("PreventiveMaintenance");
        }
    }
}