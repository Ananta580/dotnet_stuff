using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using A1_2.Data;
using A1_2.Models;
using A1_2.ViewModel;

namespace A1_2.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly A1_2Context _context;

        public ProjectsController(A1_2Context context)
        {
            _context = context;
        }

        // GET: Projects
        public async Task<IActionResult> Index()
        {
              return View(await _context.Project.Include(x=>x.ProjectResources).ThenInclude(x=>x.Resource).ToListAsync());
        }

        // GET: Projects/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.Project
                .FirstOrDefaultAsync(m => m.Id == id);
            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }

        // GET: Projects/Create
        public IActionResult Create()
        {
            ViewBag.Resources = new SelectList(_context.Resource, "Id", "Name");
            return View();
        }

        // POST: Projects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,StartDate,EndDate, ResourcesId")] ProjectViewModel project)
        {
            if (ModelState.IsValid)
            {

                var projectResources = new List<ProjectResource>();
                project.ResourcesId.ForEach(x=>projectResources.Add(new ProjectResource()
                {
                    ResourceId = x
                }));
                var dbProject = new Project()
                {
                    Id = project.Id,
                    Name = project.Name,
                    Description = project.Description,
                    StartDate = project.StartDate,
                    EndDate = project.EndDate,
                    ProjectResources = projectResources
                };
                _context.Project.Add(dbProject);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Resources = new SelectList(_context.Resource, "Id", "Name");
            return View(project);
        }

        // GET: Projects/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dbProject = await _context.Project.Include(x=>x.ProjectResources).FirstOrDefaultAsync(x=>x.Id == id);
            if (dbProject == null)
            {
                return NotFound();
            }
            
            ViewBag.Resources = new SelectList(_context.Resource, "Id", "Name");
            return View(new ProjectViewModel()
            {
                Id = dbProject.Id,
                Name = dbProject.Name,
                Description = dbProject.Description,
                EndDate = dbProject.EndDate,
                StartDate = dbProject.StartDate,
                ResourcesId = dbProject.ProjectResources.Select(x => x.ResourceId).ToList()
            });
        }

        // POST: Projects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,StartDate,EndDate, ResourcesId")] ProjectViewModel project)
        {
            if (id != project.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    List<ProjectResource> projectResources;
                    var dbProject = await _context.Project.Include(x=>x.ProjectResources).FirstOrDefaultAsync(x=>x.Id == id);
                    if (dbProject != null)
                    {
                        dbProject.Name = project.Name;
                        dbProject.Description = project.Description;
                        dbProject.StartDate = project.StartDate;
                        dbProject.EndDate = project.EndDate;
                        projectResources = dbProject.ProjectResources.ToList();
                        foreach (var resource in project.ResourcesId)
                        {
                            if (!projectResources.Exists(x => x.ResourceId == resource))
                            {
                                projectResources.Add(new ProjectResource()
                                {
                                    ResourceId = resource
                                });
                            }
                        }

                        dbProject.ProjectResources =
                            projectResources.FindAll(x => project.ResourcesId.Contains(x.ResourceId));
                        _context.Project.Update(dbProject);
                    }

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectExists(project.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Resources = new SelectList(_context.Resource, "Id", "Name");
            return View(project);
        }
        
        private bool ProjectExists(int id)
        {
          return (_context.Project?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
