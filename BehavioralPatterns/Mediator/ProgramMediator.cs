using Mediator.Components;
using Mediator.Mediator;

var generalChat = new CollegeGeneralChat();

var ion = new Student("Ion T"); 
var danu = new Student("Danu R");
var alex = new Student("Alex G");

var dumitru = new Teacher("Dumitru F");
var vadim = new Teacher("Vadim S");

generalChat.RegisterUsers(ion, danu, alex, dumitru, vadim);

ion.Send("Salut la toti.");

dumitru.SendTo<Teacher>("La ora 14 adunare generala!");
