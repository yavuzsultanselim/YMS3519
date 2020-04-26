using Microsoft.AspNetCore.Mvc;

namespace VsCode{
    public class AppUserController:Controller
    {
            public IActionResult Index(){
                return View();
            }

            public IActionResult Register(){
                return View();
            }
            [HttpPost]
            public IActionResult Register(AppUser model){
                if(ModelState.IsValid){
                        AppUser.appUsers.Add(model);
                        return RedirectToAction("Index");
                }else{
                    return View();  
                }
                
            }
    }

}