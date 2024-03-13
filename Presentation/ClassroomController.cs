using DTO;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace Presentation
{
    [Route("classroom")]
    [ApiController]
    public class ClassroomController : ControllerBase
    {
        private readonly IClassroomService _classroomService;

        public ClassroomController(IClassroomService classroomService) { _classroomService = classroomService; }

        [HttpGet("{cid}")]
        public async Task<IActionResult> GetClassrooms(string cid, [FromQuery] int month, [FromQuery] int week)
        {
            dynamic classroomData;

            if (month != 0 && week != 0)
            {
                classroomData = await _classroomService.GetClassroomByTime(cid, month, week, false);
            }
            else
            {
                classroomData = await _classroomService.GetClassroomHistory(cid, false);
            }
            return Ok(classroomData);
        }

        [HttpPost]
        public async Task<IActionResult> CreateNewClassroom([FromBody] ClassroomCreationDTO classroom)
        {
            var classroomData = await _classroomService.CreateClassroom(classroom);
            return Ok(classroomData);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteClassroom([FromBody] ClassroomDeleteDTO classroom)
        {
            await _classroomService.DeleteClassroom(classroom, true);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateClassroom([FromBody] ClassroomUpdateDTO classroom)
        {
            await _classroomService.UpdateClassroom(classroom, true);
            return Ok();
        }
    }
}
