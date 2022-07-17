namespace  Excercism
{
    class Program
    {


        public static void Main()
        {
            /***********************************************************************************
          //Exc.1
          //Console.WriteLine(HelloWorld.Hello());
          //Exc.2
          //int[] birdsObservedForDays = { 0, 2, 5, 3, 7, 8, 4 };
          //BirdCount birds = new BirdCount(birdsObservedForDays);
          //int[] b = new int[birdsObservedForDays.Length];
          //b=BirdCount.LastWeek();
          //foreach (var item in b)
          //{
          //    Console.WriteLine(item);
          //}
          //Console.WriteLine($"Bird observed today: {birds.Today()}");
          //birds.IncrementTodaysCount();
          //Console.WriteLine($"Bird observed today: {birds.Today()}");
          //Console.WriteLine($"Days without birds? {birds.HasDayWithoutBirds()}"); //the first = 0 => true
          //Console.WriteLine($"Count sum for first 3 days: {birds.CountForFirstDays(3)}");
          //// A busy day is one where five or more birds have visited your garden.
          //Console.WriteLine($"There are {birds.BusyDays()} busy days (traffic of birds! > 5 visits)");
          ****************************************************************************/

            //Lasagna lasagna = new Lasagna();
            //Console.WriteLine($"Lasagna expected in oven: {lasagna.ExpectedMinutesInOven()} minutes");
            //Console.WriteLine($"Lasagna remaining time in oven: {lasagna.RemainingMinutesInOven(30)} minutes");
            //Console.WriteLine($"Lasagna preparation time by layer quantity: {lasagna.PreparationTimeInMinutes(2)} minutes");
            //Console.WriteLine($"Elapsed time by layer and oven permanence: {lasagna.ElapsedTimeInMinutes(3,20)} minutes");

            //var knightIsAwake = false;
            //bool archerIsAwake = true;
            //bool prisonerIsAwake = false;
            //bool petDogIsPresent = false;

            //Console.WriteLine($"Can fast attack can be made? {QuestLogic.CanFastAttack(knightIsAwake)}");
            //Console.WriteLine($"Can spy a group ? {QuestLogic.CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake)}");
            //Console.WriteLine($"Prisoner can be signalled ? {QuestLogic.CanSignalPrisoner(archerIsAwake, prisonerIsAwake)}");
            //Console.WriteLine($"Prisoner can be freed ? {QuestLogic.CanFreePrisoner(knightIsAwake,archerIsAwake,prisonerIsAwake,petDogIsPresent)}");

            //SecurityPassMaker securityPassMaker = new SecurityPassMaker();
            //Console.WriteLine(securityPassMaker.GetDisplayName(new Manager()));
            //Console.WriteLine(securityPassMaker.GetDisplayName(new Chairman()));
            //Console.WriteLine(securityPassMaker.GetDisplayName(new Physio()));
            //Console.WriteLine(securityPassMaker.GetDisplayName(new Security()));
            //Console.WriteLine(Identifier.Clean("My   ID"));
            //Console.WriteLine(Identifier.Clean("my\0Id"));
            //Console.WriteLine(Identifier.Clean("1😀2😀3😀"));
            //Console.WriteLine(Identifier.Clean("MyβιεγτFinder"));
            ////task1 elon's toys
            //var car = new RemoteControlCar();
            //RemoteControlCar.Buy(); //equivalent to line 57 - Buy() returns new object
            ////task2 elon's toys
            //Console.WriteLine($"Distance driven by car: {car.DistanceDisplay()}");
            ////task3 elon's toys
            //Console.WriteLine($"Battery percentage: {car.BatteryDisplay()}");
            ////task4 elon's toys
            //car.Drive();
            //Console.WriteLine($"Distance driven by car after drive: {car.DistanceDisplay()}");
            //Console.WriteLine($"Battery percentage after drive: {car.BatteryDisplay()}");
            //Authenticator au = new Authenticator(new Identity());
            //var dev = au.GetDevelopers();
            //foreach (var item in dev)
            //{
            //    Console.WriteLine(item);
            //}
            //RemoteControlCar car = new RemoteControlCar(5,2);
            //RaceTrack track = new RaceTrack(800);

            //car.Drive();
            //Console.WriteLine($"Distance driven: {car.DistanceDriven()}");
            //Console.WriteLine($"Battery drained? : {car.BatteryDrained()}");

            //RemoteControlCar carNitro = RemoteControlCar.Nitro();
            //carNitro.Drive();
            //Console.WriteLine($"Distance driven Nitro car: {carNitro.DistanceDriven()}");
            //Console.WriteLine($"Can car finish the track? {track.TryFinishTrack(car)}");
            ////task1 Booking up beauty - parse date
            //Console.WriteLine(Appointment.Schedule("30/06/2022"));
            ////task2 check date passed
            //Console.WriteLine($"{Appointment.HasPassed(new DateTime(1999, 12, 31, 9, 0, 0))}");
            ////task3 check if date is in afternoon
            //Console.WriteLine($"{Appointment.IsAfternoonAppointment(new DateTime(1999, 12, 31, 9, 0, 0))}");
            ////task4 describe date
            //Console.WriteLine($"{Appointment.Description(new DateTime(1999, 12, 31, 9, 0, 0))}");
            ////task5 return anniversary
            //Console.WriteLine($"{Appointment.AnniversaryDate()}");
            ////task1 create a dict <int, string>
            //var dict = DialingCodes.GetEmptyDictionary();
            ////task2 create prepop dict
            //var dict2 = DialingCodes.GetExistingDictionary();
            //Console.WriteLine($"{dict2[55]}");
            ////task3 add element to empty dict
            //Dictionary<int, string> empD = DialingCodes.AddCountryToEmptyDictionary(34, "Secondigliano");
            ////task4 add elemento to existing dict
            //DialingCodes.AddCountryToExistingDictionary(empD, 35, "San Paolo");
            ////task5 get element from dict
            //Console.WriteLine($"{DialingCodes.GetCountryNameFromDictionary(empD, 35)}");
            ////task6 check element in dict
            //Console.WriteLine($"{DialingCodes.CheckCodeExists(empD, 39)}");
            ////task8 remove element
            //DialingCodes.RemoveCountryFromDictionary(empD, 35);
            //Console.WriteLine($"{DialingCodes.FindLongestCountryName(empD)}");
            ////task1 faceid2 check 2 faces match
            //FacialFeatures faceA = new FacialFeatures("green",0.9m);
            //FacialFeatures faceB = new FacialFeatures("green",0.9m);
            //Console.WriteLine($"Are the same face? {Authenticator2.AreSameFace(faceA, faceB)}");

            ////task2 auth system admin
            //Authenticator2 au = new Authenticator2();
            //Identity2 adm1 = new Identity2("admin@exerc.ism", faceA);
            //Console.WriteLine($"Is Admin this identity? {au.IsAdmin(adm1)}");

            ////task3 register new id
            //var au2 = new Authenticator2();
            //var faceC = new FacialFeatures("blue", 0.7m);
            //var userNew = new Identity2("user@user.com", faceC);
            //au2.Register(userNew);
            //Console.WriteLine($"Is new user registered? {au2.IsRegistered(userNew)}");

            ////task4 prevent invalid id to be auth
            //var idUnknown = new Identity2("notMe", faceC);
            //Console.WriteLine($"Is this id registered? {au2.IsRegistered(idUnknown)}");
            ////task1 calculatur conundrum - implement operations 
            //Console.WriteLine($"Calculate: {SimpleCalculator.Calculate(3, 5, "*")}");
            ////task2 illegal operations
            //Console.WriteLine($"Calculate: {SimpleCalculator.Calculate(100, 0, "/   ")}");
            ////task1 attack of trolls
            //Console.WriteLine(Permissions.Default(AccountType.User));
            //Permissions.Grant(Permission.Read,Permission.Write);
            //Console.WriteLine(Permissions.Default(AccountType.User));
            //Permissions.Revoke(Permission.Read,Permission.Read);   
            //Permissions.Check(Permission.Read,Permission.Write);    

            ////task1 wizardwarriors describe a character
            //Warrior warrior = new Warrior();
            //var a = warrior.ToString();
            //Console.WriteLine(a);
            ////task2 make character not vulnerable by default
            //var v = warrior.Vulnerable();
            //Console.WriteLine(v);
            //Wizard wizard = new Wizard();
            ////task3 wizard prepare spell
            //wizard.PrepareSpell();
            ////task4 wizard vulnerable if not prepare spell
            //var wv = wizard.Vulnerable();
            //Console.WriteLine(wv);
            //var dp = wizard.DamagePoints(warrior);
            //Console.WriteLine(dp);
            //var dp2 = warrior.DamagePoints(wizard);
            //Console.WriteLine(dp2);
            //ProductionRemoteControlCar car1 = new ProductionRemoteControlCar();
            //ExperimentalRemoteControlCar car2 = new();

            //TestTrack.Race(car1);
            //TestTrack.Race(car2);
            //var dist1 = car1.DistanceTravelled;
            //var dist2 = car2.DistanceTravelled;
            //Console.WriteLine(dist1);
            //Console.WriteLine(dist2);
            //var s = LogAnalysis.SubstringBetween("FIND >>> CIAO <===< HERE", ">>> ", " <===<");
            //Console.WriteLine(s);


            //var c = ">>> Ciao sono io <<<".Split(" <<<").First().Split(">>> ").Last();
            //var d = ">>> Ciao sono io <<<".Split(" <<<").First();
            //var e = ">>> Ciao sono io <<<".Split(">>> ").Last();
            //Console.WriteLine(e);
            //SpaceAge age = new SpaceAge(2134835688);
            //Console.WriteLine(age.AgeInSeconds);
            //Console.WriteLine($"Age on Earth: {Math.Round(age.OnEarth(),2)}");
            //Console.WriteLine($"Age on Mercury: {Math.Round(age.OnMercury(),2)}");

            Robot robot = new Robot();
            var x = robot.Name;



        }
    }
}