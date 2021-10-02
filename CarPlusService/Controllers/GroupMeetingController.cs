using Common.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceDAL.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarPlusService.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class GroupMeetingController : ControllerBase
    {
        [HttpGet("GetGroupMeetings")]
        public IActionResult GetGroupMeetings()
        {
            return Ok(GroupMeetingService.GetGroupMeetings());
        }

        [HttpPost("AddGroupMeeting")]
        public IActionResult AddGroupMeeting([Bind] GroupMeeting groupMeeting)
        {
            if (ModelState.IsValid)
            {
                if (GroupMeetingService.AddGroupMeeting(groupMeeting) > 0)
                {
                    return RedirectToAction("Index");
                }
            }
            return Ok(groupMeeting);
        }

        [HttpGet("EditMeeting")]
        public IActionResult EditMeeting(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            GroupMeeting group = GroupMeetingService.GetGroupMeetingById(id);
            if (group == null)
                return NotFound();
            return Ok(group);
        }

        [HttpPost]
        public IActionResult EditMeeting(int id, [Bind] GroupMeeting groupMeeting)
        {
            if (id != groupMeeting.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                GroupMeetingService.UpdateGroupMeeting(groupMeeting);
                return Ok("Index");
            }
            return Ok(groupMeeting);
        }

        [HttpPost("DeleteMeeting")]
        public IActionResult DeleteMeeting(int id)
        {
            GroupMeeting group = GroupMeetingService.GetGroupMeetingById(id);
            if (group == null)
            {
                return NotFound();
            }

            return Ok(group);
        }

        [HttpPost("DeleteMeeting/id")]
        public IActionResult DeleteMeeting(int id, GroupMeeting groupMeeting)
        {
            if (GroupMeetingService.DeleteGroupMeeting(id) > 0)
            {
                return RedirectToAction("Index");
            }
            return Ok(groupMeeting);
        }
    }

   
}
