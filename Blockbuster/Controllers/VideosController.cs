using Microsoft.AspNetCore.Mvc;
using Blockbuster.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace Blockbuster.Controllers
{
  public class VideosController : Controller
  {
    private readonly BlockbusterContext _db;
    
  }
}