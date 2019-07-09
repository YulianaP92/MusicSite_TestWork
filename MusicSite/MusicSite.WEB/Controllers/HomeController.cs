using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using MusicSite.BLL.DTO;
using MusicSite.BLL.Interfaces;
using MusicSite.WEB.Models;

namespace MusicSite.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly IService<SongDto> songService;

        public HomeController(IService<SongDto> songService)
        {
            this.songService = songService;
        }
        public ActionResult Index()
        {
            var songDtoList = songService.GetAll().ToList();
            var songViewModelList= Mapper.Map<List<SongDto>, List<SongViewModel>>(songDtoList);
            return View(songViewModelList);
        }
    }
}