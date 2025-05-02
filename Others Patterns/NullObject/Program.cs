using ConsoleNullObject.Models;

var mobileRepository = new MobileRepository();
var mobile = mobileRepository.GetMobileByName("sony");
mobile.Ativar();
mobile.Desativar();

var mobileRepository2 = new MobileRepository();
var mobile2 = mobileRepository2.GetMobileByName("teste");
mobile2.Ativar();
mobile2.Desativar();