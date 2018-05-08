using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace InternPortal.WebTests.Test_Methods
{
    public partial class TestMethods : BaseWebTest
    {
        [Given("Username (.*) logged in with password (.*)")]
        public void GivenUserLoggedIn(string username, string password)
        {
            GivenIAmOnPage("Account/Login");
            WhenTextEntered(username, "UserName");
            WhenTextEntered(password, "Password");
            WhenElementIdClicked("submit");
            ThenThePageShouldBeDisplayed("");
        }

        [When(@"I Complete Eula (.*) (.*)")]
        public void WhenCompleteEula(string initial, string name)
        {
            WhenCheckBoxIsChecked("SignatureAgreementList_0__IsEULAConfirmed");

            var initialBoxes = Driver.FindElements(By.ClassName("initialsInput"));
            foreach (var box in initialBoxes)
            {
                WhenTextEntered(box.GetAttribute("id"), initial);
            }

            WhenCheckBoxIsChecked("SignatureAgreementList_1__IsEULAConfirmed");
            WhenTextEntered("Name", name);
            //System.Threading.Thread.Sleep(20000);
            WhenElementIdClicked("signInDonor");
        }

        [When(@"I Complete W9 Form Any Info")]
        public void WhenICompleteW9FormAnyInfo()
        {
            WhenPause(10000);
            WhenTextEntered("Business", "Prolacta");
            WhenTextEntered("SSN", "123224444");
            WhenTextEntered("SelectedItem", "C_Corp");
            WhenTextEntered("ExemptionPayeeCode", "EPC");
            WhenTextEntered("ExemptionFatcaCode", "EFC");
            WhenTextEntered("AccountNos", "accounts");
            WhenTextEntered("RequesterNameAdd", "Add");
            WhenElementIdClicked("btnSubmitRequired");
            WhenButtonIsClickedWaitTime("ui-dialog-buttonpane", "button", 10);
            WhenPause(10000);


        }

        [When(@"I Enter Any Babys Information")]
        public void WhenIEnterAnyBabysInformation()
        {
            WhenTextEntered("BabyInformation_BIFirstName", "Any");
            WhenTextEntered("BabyInformation_BILastName", "Any");
            WhenDropDownPicked("BabyInformation_BISex", "Male");
            WhenDropDownPicked("BabyInformation_BIBirthDate_Value_Month", "October");
            WhenDropDownPicked("BabyInformation_BIBirthDate_Value_Day", "28");
            WhenDropDownPicked("BabyInformation_BIBirthDate_Value_Year", "2017");
            WhenDropDownPicked("BabyInformation_BIBabyFullTerm", "Yes");
            WhenElementIdClicked("nextBtn");
        }

        [When(@"I Enter Initial Information (.*)")]
        public void WhenIEnterInitialInformation_1(string radioButton)
        {
            bool answerTrue;
            bool.TryParse(radioButton, out answerTrue);

            WhenRadioIsSelected("InterviewQuestionList_SectionCollection_4__QuestionCollection_Radiobutton_8813", radioButton); //#1
            if (answerTrue)
            {
                WhenTextEntered("InterviewQuestionList_SectionCollection_4__QuestionCollection_Textbox_8814", "The MilkBank of NY");
            }
            WhenRadioIsSelected("InterviewQuestionList_SectionCollection_4__QuestionCollection_Radiobutton_8815", radioButton); //#2
            if (answerTrue)
            {
                WhenTextEntered("InterviewQuestionList_SectionCollection_4__QuestionCollection_Textbox_8816", "The Milk Bank of CA");
                WhenRadioIsSelected("InterviewQuestionList_SectionCollection_4__QuestionCollection_Radiobutton_8817", radioButton);
                WhenTextEntered("InterviewQuestionList_SectionCollection_4__QuestionCollection_Textbox_8818", "Debbie Dorn");
                WhenRadioIsSelected("InterviewQuestionList_SectionCollection_4__QuestionCollection_Radiobutton_8812", radioButton);
            }

            WhenRadioIsSelected("Start_NoneOfTheseApply", "true");//#3
            WhenElementIdClicked("nextBtn");
        }

        [When(@"I Enter Any Mothers HealthCare Information")]
        public void WhenIEnterAnyMothersHealthCareInformation()
        {
            WhenTextEntered("MotherHealthCareProfessional_MHCName", "random");
            WhenTextEntered("MotherHealthCareProfessional_MHCPhone", "1234567890");
            WhenTextEntered("MotherHealthCareProfessional_MHCAddress", "random");
            WhenTextEntered("MotherHealthCareProfessional_MHCCity", "random");
            WhenDropDownPicked("MotherHealthCareProfessional_MHCProvstate", "California");
            WhenDropDownPicked("MotherHealthCareProfessional_MHCCountry", "U.S.");
            WhenTextEntered("MotherHealthCareProfessional_MHCZipCode", "90031");
            WhenElementIdClicked("nextBtn");
        }
        [When(@"Baby HealthCare same as Mothers Information")]
        public void WhenBabyHealthCareSameAsMothersInformation()
        {
            WhenCheckBoxIsChecked("BabyHealthCareProfessional_BHCSameAsMotherHC");
            WhenElementIdClicked("nextBtn");
        }

        [When(@"I Answer 1-10 Donors Medical History (.*)")]
        public void WhenIAnswerFirst10DonorsMedicalHistory(string radioButton)
        {
            //determine if subquestion need to be answered.
            bool answerTrue;
            bool.TryParse(radioButton, out answerTrue);

            WhenRadioIsSelected("Radiobutton_8624", radioButton); // #1
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8625", "1");
            }
            WhenRadioIsSelected("Radiobutton_8626", radioButton); // #2
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8627", "Name 10/10/2010");
            }
            WhenRadioIsSelected("Radiobutton_8628", radioButton); // #3
            if (!answerTrue)
            {
                WhenTextEntered("Textbox_8629", "Family was sick");
            }
            WhenRadioIsSelected("Radiobutton_8630", radioButton); // #4
            WhenCheckBoxIsChecked("Checkbox_8634"); // #5
            WhenCheckBoxIsChecked("Checkbox_8635");
            WhenRadioIsSelected("Radiobutton_8636", radioButton); // #6
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8637", "True");
            }
            WhenRadioIsSelected("Radiobutton_8638", radioButton); // #7
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8639", "true");
            }
            WhenRadioIsSelected("Radiobutton_8640", radioButton); // #8
            if (!answerTrue)
            {
                WhenTextEntered("Textbox_8641", "true");
            }
            WhenRadioIsSelected("Radiobutton_8642", radioButton); // #9
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8643", "true");
            }
            WhenRadioIsSelected("Radiobutton_8644", radioButton); // #10
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8645", "true");
            }
            WhenElementIdClicked("nextBtn");
        }

        [When(@"I Answer 11-20 Donors Medical History All (.*)")]
        public void WhenIAnswerSecond10DonorsMedicalHistoryAllTrue(string radioButton)
        {
            //determine if subquestion need to be answered.
            bool answerTrue;
            bool.TryParse(radioButton, out answerTrue);

            WhenRadioIsSelected("Radiobutton_8646", radioButton); // #11
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8647", "true");
            }
            WhenRadioIsSelected("Radiobutton_8648", radioButton); // #12
            if (!answerTrue)
            {
                WhenTextEntered("Textbox_8649", "explain");
            }
            WhenRadioIsSelected("Radiobutton_8650", radioButton); // #13
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8651", "true");
            }
            WhenRadioIsSelected("Radiobutton_8652", radioButton); // #14
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8653", "true");
            }
            WhenRadioIsSelected("Radiobutton_8654", radioButton); // #15

            WhenRadioIsSelected("Radiobutton_8655", radioButton); // #16
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8656", "true");
            }
            WhenRadioIsSelected("Radiobutton_8657", radioButton); // #17
            if (!answerTrue)
            {
                WhenTextEntered("Textbox_8658", "true");
            }
            WhenRadioIsSelected("Radiobutton_8659", radioButton); // #18
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8660", "true");
            }
            WhenRadioIsSelected("Radiobutton_8661", radioButton); // #19
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8662", "true");
            }
            WhenRadioIsSelected("Radiobutton_8663", radioButton); // #20
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8664", "true");
            }
            WhenElementIdClicked("nextBtn");
        }

        [When(@"I Answer 21-30 Donors Medical History All (.*)")]
        public void WhenIAnswerThird10DonorMedicalHistoryAllTrue(string radioButton)
        {
            //determine if subquestion need to be answered.
            bool answerTrue;
            bool.TryParse(radioButton, out answerTrue);

            WhenRadioIsSelected("Radiobutton_8665", radioButton); // #21
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8666", "true");
            }
            WhenRadioIsSelected("Radiobutton_8667", radioButton); // #22
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8668", "true");
            }
            WhenRadioIsSelected("Radiobutton_8669", radioButton); // #23
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8670", "true");
            }
            WhenRadioIsSelected("Radiobutton_8671", radioButton); // #24
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8672", "true");
            }
            WhenRadioIsSelected("Radiobutton_8673", radioButton); // #25
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8674", "true");
            }
            WhenRadioIsSelected("Radiobutton_8675", radioButton); // #26
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8676", "true");
            }
            WhenRadioIsSelected("Radiobutton_8677", radioButton); // #27
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8678", "true");
            }
            WhenRadioIsSelected("Radiobutton_8679", radioButton); // #28
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8680", "true");
            }
            WhenRadioIsSelected("Radiobutton_8681", radioButton); // #29
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8682", "true");
            }
            WhenRadioIsSelected("Radiobutton_8683", radioButton); // #30
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8684", "true");
            }
            WhenElementIdClicked("nextBtn");

        }

        [When(@"I Answer 31-40 Donors Medical History All (.*)")]
        public void WhenIAnswerFourth10DonorMedicalHistoryAllTrue(string radioButton)
        {
            //determine if subquestion need to be answered.
            bool answerTrue;
            bool.TryParse(radioButton, out answerTrue);

            WhenRadioIsSelected("Radiobutton_8685", radioButton); // #31
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8686", "true");
            }
            WhenRadioIsSelected("Radiobutton_8687", radioButton); // #32
            WhenRadioIsSelected("Radiobutton_8688", radioButton); // #33
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8689", "true");
            }
            WhenRadioIsSelected("Radiobutton_8690", radioButton); // #34
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8691", "true");
            }
            WhenRadioIsSelected("Radiobutton_8692", radioButton); // #35
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8693", "true");
            }
            WhenRadioIsSelected("Radiobutton_8694", radioButton); // #36
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8695", "true");
            }
            WhenRadioIsSelected("Radiobutton_8696", radioButton); // #37
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8697", "true");
            }
            WhenRadioIsSelected("Radiobutton_8698", radioButton); // #38
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8699", "true");
            }
            WhenRadioIsSelected("Radiobutton_8700", radioButton); // #39
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8701", "true");
            }
            WhenRadioIsSelected("Radiobutton_8702", radioButton); // #40
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8703", "true");
            }
            WhenElementIdClicked("nextBtn");
        }

        [When(@"I Answer 41-50 Donors Medical History All (.*)")]
        public void WhenIAnswerFifth10DonorMedicalHistoryAllTrue(string radioButton)
        {
            //determine if subquestion need to be answered.
            bool answerTrue;
            bool.TryParse(radioButton, out answerTrue);

            WhenRadioIsSelected("Radiobutton_8704", radioButton); // #41
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8705", "true");
            }
            WhenRadioIsSelected("Radiobutton_8706", radioButton); // #42
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8707", "true");
            }
            WhenRadioIsSelected("Radiobutton_8708", radioButton); // #43
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8709", "true");
            }
            WhenRadioIsSelected("Radiobutton_8710", radioButton); // #44
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8711", "true");
            }
            WhenRadioIsSelected("Radiobutton_8712", radioButton); // #45
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8713", "true");
            }
            WhenRadioIsSelected("Radiobutton_8714", radioButton); // #46
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8715", "true");
            }
            WhenRadioIsSelected("Radiobutton_8716", radioButton); // #47
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8717", "true");
            }
            WhenRadioIsSelected("Radiobutton_8718", radioButton); // #48
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8719", "true");
            }
            WhenRadioIsSelected("Radiobutton_8720", radioButton); // #49
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8721", "true");
            }
            WhenRadioIsSelected("Radiobutton_8722", radioButton); // #50
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8723", "true");
            }
            WhenElementIdClicked("nextBtn");
        }

        [When(@"I Answer 51-60 Donors Medical History All (.*)")]
        public void WhenIAnswerSixth10DonorMedicalHistoryAllTrue(string radioButton)
        {
            //determine if subquestion need to be answered.
            bool answerTrue;
            bool.TryParse(radioButton, out answerTrue);

            WhenRadioIsSelected("Radiobutton_8724", radioButton); // #51
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8725", "true");
            }
            WhenRadioIsSelected("Radiobutton_8726", radioButton); // #52
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8727", "true");
            }
            WhenRadioIsSelected("Radiobutton_8728", radioButton); // #53
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8729", "true");
            }
            WhenRadioIsSelected("Radiobutton_8730", radioButton); // #54
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8731", "true");
            }
            WhenRadioIsSelected("Radiobutton_8732", radioButton); // #55
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8733", "true");
            }
            WhenRadioIsSelected("Radiobutton_8734", radioButton); // #56
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8735", "true");
            }
            WhenRadioIsSelected("Radiobutton_8736", radioButton); // #57
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8737", "true");
            }
            WhenRadioIsSelected("Radiobutton_8738", radioButton); // #58
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8739", "true");
            }
            WhenRadioIsSelected("Radiobutton_8740", radioButton); // #59
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8741", "true");
            }
            WhenRadioIsSelected("Radiobutton_8742", radioButton); // #60
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8743", "true");
            }
            WhenElementIdClicked("nextBtn");
        }

        [When(@"I Answer 61-70 Donors Medical History All (.*)")]
        public void WhenIAnswerSeventh10DonorMedicalHistoryAllTrue(string radioButton)
        {
            //determine if subquestion need to be answered.
            bool answerTrue;
            bool.TryParse(radioButton, out answerTrue);

            WhenRadioIsSelected("Radiobutton_8744", radioButton); // #61
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8745", "true");
            }
            WhenRadioIsSelected("Radiobutton_8746", radioButton); // #62
            if (!answerTrue)
            {
                WhenTextEntered("Textbox_8747", "true");
            }
            WhenRadioIsSelected("Radiobutton_8748", radioButton); // #63
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8749", "true");
            }
            WhenRadioIsSelected("Radiobutton_8750", radioButton); // #64
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8751", "true");
            }
            WhenRadioIsSelected("Radiobutton_8752", radioButton); // #65
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8753", "true");
            }
            WhenRadioIsSelected("Radiobutton_8754", radioButton); // #66
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8755", "true");
            }
            WhenRadioIsSelected("Radiobutton_8756", radioButton); // #67
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8757", "true");
            }
            WhenRadioIsSelected("Radiobutton_8758", radioButton); // #68
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8759", "true");
            }
            WhenRadioIsSelected("Radiobutton_8760", radioButton); // #69
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8761", "true");
            }
            WhenRadioIsSelected("Radiobutton_8762", radioButton); // #70
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8763", "true");
            }
            WhenElementIdClicked("nextBtn");
        }

        [When(@"I Answer 71-80 Donors Medical History All (.*)")]
        public void WhenIAnswerEighth10DonorMedicalHistoryAllTrue(string radioButton)
        {
            //determine if subquestion need to be answered.
            bool answerTrue;
            bool.TryParse(radioButton, out answerTrue);

            WhenRadioIsSelected("Radiobutton_8764", radioButton); // #71
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8765", "true");
            }
            WhenRadioIsSelected("Radiobutton_8766", radioButton); // #72
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8767", "true");
            }
            WhenRadioIsSelected("Radiobutton_8768", radioButton); // #73
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8769", "true");
            }
            WhenTextEntered("Textbox_8770", "true");         // #74
            WhenRadioIsSelected("Radiobutton_8771", radioButton); // #75
            WhenRadioIsSelected("Radiobutton_8772", radioButton); // #76
            WhenRadioIsSelected("Radiobutton_8776", "true"); // #77 Up to 9 months
            WhenRadioIsSelected("Radiobutton_8779", radioButton); // #78
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8780", "true");
            }
            WhenRadioIsSelected("Radiobutton_8782", "true"); // #79 This is my first child
            WhenRadioIsSelected("Radiobutton_8789", "true"); // #80 High School Disploma
            WhenElementIdClicked("nextBtn");
        }

        [When(@"I Answer 81-83 Donors Medical History All (.*)")]
        public void WhenIAnswerNinth10DonorMedicalHistoryAllTrue(string radioButton)
        {
            //determine if subquestion need to be answered.
            bool answerTrue;
            bool.TryParse(radioButton, out answerTrue);

            WhenRadioIsSelected("Radiobutton_8796", "true"); // #81 Caucasian
            WhenRadioIsSelected("Radiobutton_8803", "true"); // #82 less then 25k
            WhenRadioIsSelected("Radiobutton_8808", radioButton); // #83
            if (answerTrue)
            {
                WhenTextEntered("Textbox_8809", "true");
            }
        }
    }
}
