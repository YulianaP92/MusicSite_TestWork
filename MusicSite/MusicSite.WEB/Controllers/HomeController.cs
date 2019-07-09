using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using MusicSite.BLL.DTO;
using MusicSite.BLL.Interfaces;
using MusicSite.WEB.Models;

namespace MusicSite.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly IService<SongDto> _songService;
        public HomeController(IService<SongDto> songService)
        {
            _songService = songService;
        }
        public ActionResult Index()
        {
            try
            {
                var songDtoList = _songService?.GetAll()?.ToList();
                var songViewModelList = Mapper.Map<List<SongDto>, List<SongViewModel>>(songDtoList);
                return View(songViewModelList);
            }
            catch (Exception e)
            {
                return Content(e.Message);
            }
        }

        [HttpPost]
        public ActionResult Search(string searchString)
        {
            try
            {
                var songs = _songService?.GetAll()?.ToList();
                var songViewModelList = Mapper.Map<List<SongDto>, List<SongViewModel>>(songs);
                if (!string.IsNullOrEmpty(searchString))
                {
                    songViewModelList = songViewModelList?.Where(s => s.Name.ToUpper().Contains(searchString.ToUpper())).ToList();
                }
                return PartialView("MySongList", songViewModelList);
            }
            catch (Exception e)
            {
                return Content(e.Message);
            }
        }
    }
}