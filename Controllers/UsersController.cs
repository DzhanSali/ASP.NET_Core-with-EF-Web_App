using Microsoft.AspNetCore.Mvc;
using Web2Project.Entities;
using Web2Project.Repositories;
using Web2Project.ViewModels.Users;

namespace Web2Project.Controllers
{
    public class UsersController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            DatabaseContext context = new DatabaseContext();
            IndexVM model = new IndexVM();
            CreateVM cmodel = new CreateVM();
            model.Items = context.Users.ToList();
            cmodel.SkillList = context.SkillSet.ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            //CreateVM model = new CreateVM();
            //return View(model);
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateVM model)
        {
            if (!ModelState.IsValid) { return View(model); }

            if (ModelState.IsValid)
            {
                using (DatabaseContext dc = new DatabaseContext())
                {
                    GeneralUser item = new GeneralUser();
                    item.Username = model.Username;
                    item.Password = model.Password;
                    item.FirstName = model.FirstName;
                    item.LastName = model.LastName;
                    item.EmailAddress = model.EmailAddress;
                    item.PhoneNumber = model.PhoneNumber;

                    //Skills skills = new Skills();
                    //skills.SkillName = model.SkillName;


                    DatabaseContext context = new DatabaseContext();
                    context.Users.Add(item);
                    dc.Users.Add(item);
                    //context.SkillSet.Add(skills);
                    context.SaveChanges();
                    dc.SaveChanges();


                    context.SaveChangesAsync();
                    context.Add<GeneralUser>(item);
                    context.Add<CreateVM>(model);
                    context.Update(context);
                }
            }

            return RedirectToAction("Index", "Users");
        }


        [HttpGet]
        public IActionResult QuickApplication()
        {
            return View();
        }

        [HttpPost]
        public IActionResult QuickApplication(QuickApplicationVM mod)
        {
            if (ModelState.IsValid)
            {
                using (DatabaseContext dc = new DatabaseContext())
                {
                    GeneralUser gu = new GeneralUser();
                    gu.FirstName = mod.FirstName;
                    gu.LastName = mod.LastName;
                    gu.EmailAddress = mod.EmailAddress;
                    gu.PhoneNumber = mod.PhoneNumber;

                    Skills skills = new Skills();
                    skills.SkillName = mod.SkillName;

                    Jobs jb = new Jobs(); 
                    jb.JobName = mod.JobName;


                    DatabaseContext context = new DatabaseContext();
                    context.Users.Add(gu);
                    dc.Users.Add(gu);

                    context.SkillSet.Add(skills);
                    dc.SkillSet.Add(skills);

                    context.Job.Add(jb);
                    dc.Job.Add(jb);
                    
                    context.SaveChanges();
                    dc.SaveChanges();

                    return RedirectToAction("Index", "Users");
                }
            }
            else { return View(mod); }
        }
    }
}
