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
    public class ACR_PumpOnGround_SRController : Controller
    {
        private readonly ApplicationDbContext context;

        public ACR_PumpOnGround_SRController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult> ServiceReport()
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
                var fileModel = new ACR_PumpOnGround_FileOnDatabaseModelSR
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
                context.ACR_PumpOnGround_FileOnDatabaseSR.Add(fileModel);
                context.SaveChanges();
            }
            TempData["Message"] = "File successfully uploaded to Database";
            return RedirectToAction("ServiceReport");
        }

        private async Task<ACR_PumpOnGround_FileUploadViewModelSR> LoadAllFiles()
        {
            var viewModel = new ACR_PumpOnGround_FileUploadViewModelSR();
            viewModel.ACR_PumpOnGround_FilesOnDatabaseSR = await context.ACR_PumpOnGround_FileOnDatabaseSR.ToListAsync();
            return viewModel;
        }

        public async Task<IActionResult> DownloadFileFromDatabase(int id)
        {

            var file = await context.ACR_PumpOnGround_FileOnDatabaseSR.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (file == null) return null;
            return File(file.Data, file.FileType, file.Name + file.Extension);
        }

        public async Task<IActionResult> DeleteFileFromDatabase(int id)
        {

            var file = await context.ACR_PumpOnGround_FileOnDatabaseSR.Where(x => x.Id == id).FirstOrDefaultAsync();
            context.ACR_PumpOnGround_FileOnDatabaseSR.Remove(file);
            context.SaveChanges();
            TempData["Message"] = $"Removed {file.Name + file.Extension} successfully from Database.";
            return RedirectToAction("ServiceReport");
        }
    }
}