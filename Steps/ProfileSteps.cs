using AdvancedTaskPart1.AssertHelpers;
using AdvancedTaskPart1.Model;
using AdvancedTaskPart1.Pages.ProfileAboutMe;
using AdvancedTaskPart1.Utilits;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonReader = AdvancedTaskPart1.Utilits.JsonReader;

namespace AdvancedTaskPart1.Steps
{
    public class ProfileSteps:CommonDriver
    {
        Profilecomponent profileComponent;

        public ProfileSteps()
        {
            profileComponent = new Profilecomponent();
        }

        public void editAvailability(int id)
        {
           ProfileData profileData = JsonReader.LoadData<ProfileData>(@"ProfileData.json").FirstOrDefault(x => x.Id == id);

            profileComponent.editAvailability(profileData.Availability);
            // Retrieve the message displayed after updating Availability
            string actualMessage = "Availability updated";
            ProfileAssertHelper.assertAvailabilitySuccessMessage(profileData.ExpectedMessage, actualMessage);
            Console.WriteLine(actualMessage);
        }

        public void cancelAvailability()
        {
            profileComponent.cancelAvailabilityButton();
        }

        public void editHours(int id)
        {
            ProfileData profileData = JsonReader.LoadData<ProfileData>(@"ProfileData.json").FirstOrDefault(x => x.Id == id);
            profileComponent.editHours(profileData.Hours);
            string actualMessage = "Availability updated";
            ProfileAssertHelper.assertHoursSuccessMessage(profileData.ExpectedMessage, actualMessage);
            Console.WriteLine(actualMessage);
        }

        public void editEarnTarget(int id)
        {
            ProfileData profileData = JsonReader.LoadData<ProfileData>(@"ProfileData.json").FirstOrDefault(x => x.Id == id);
            profileComponent.editEarnTarget(profileData.EarnTarget);
            string actualMessage = "Availability updated";
            ProfileAssertHelper.assertEarnTargetSuccessMessage(profileData.ExpectedMessage, actualMessage);
            Console.WriteLine(actualMessage);
        }
    }
}
