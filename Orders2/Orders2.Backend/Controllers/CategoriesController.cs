﻿using Microsoft.AspNetCore.Mvc;
using Orders2.Backend.UnitsOfWork.Interfaces;
using Orders2.Shared.Entities;

namespace Orders2.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : GenericController<Category>
    {
        public CategoriesController(IGenericUnitOfWork<Category> unitOfWork) : base(unitOfWork)
        {
        }
    }
}