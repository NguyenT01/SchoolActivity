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
        public async Task<IActionResult> GetClassrooms(string cid)
        {
            var classroomData = await _classroomService.GetClassroomHistory(cid, false);
            return Ok(classroomData);
        }
    }
}
