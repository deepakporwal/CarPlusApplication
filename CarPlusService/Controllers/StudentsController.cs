﻿using Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarPlusService.Validators;
using FluentValidation.Results;
using FluentValidation;

namespace CarPlusService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        public StudentsController()
        {
           
        }

        [HttpGet("Getstudents")]
        public async Task<ActionResult<StudentDataDTO>> GetStudents() 
        {

            return Ok("Success");
        }

        [HttpPost("AddStudent")]
        public async Task<ActionResult<StudentDataDTO>> AddStudent(StudentData payload)
        {
            return Ok(payload);
        }
    }
}
