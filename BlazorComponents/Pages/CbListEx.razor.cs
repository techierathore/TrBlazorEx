using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace BlazorComponents.Pages
{
    public class CbListExBase : ComponentBase
    {
        public List<Employee> EmployeeList { get; set; }
        protected List<string> SelectedIds = new List<string>();
        public List<Employee> ObjectList { get; set; }
        public string OutPutValue { get; set; }
        protected override void OnInitialized()
        {
            EmployeeList = GetMockEmployees();
        }

        protected void ShowSelectedValues()
        {
            OutPutValue = string.Join(",", SelectedIds.ToArray()); 
            StateHasChanged();
        }
        private List<Employee> GetMockEmployees()
        {

            var vSubOne = new Employee()
            {
                EmployeeId = 4,
                FirstName = "S Ravi",
                LastName = "Kumar",
                MobileNo = "9901091975",
                Email = "SKumar@gmail.com"
            };
            var vSubTwo = new Employee()
            {
                EmployeeId = 6,
                FirstName = "Payal",
                LastName = "Jain",
                MobileNo = "9001091905",
                Email = "PJain@gmail.com"
            };
            var vSubThree = new Employee()
            {
                EmployeeId = 7,
                FirstName = "Alok",
                LastName = "Ojha",
                MobileNo = "900091905",
                Email = "AOjha@gmail.com"
            };
            var vSubFour = new Employee()
            {
                EmployeeId = 9,
                FirstName = "Divya",
                LastName = "Bharti",
                MobileNo = "9111767895",
                Email = "DBharti@gmail.com"
            };
            var vSubFive = new Employee()
            {
                EmployeeId = 10,
                FirstName = "Mayuri",
                LastName = "Kango",
                MobileNo = "9111000025",
                Email = "MKango@gmail.com"
            };
            var vSubSix = new Employee()
            {
                EmployeeId = 11,
                FirstName = "Tamraj",
                LastName = "Kilwish",
                MobileNo = "9251000025",
                Email = "TKilwish@gmail.com"
            };
            var vSubSeven = new Employee()
            {
                EmployeeId = 12,
                FirstName = "James",
                LastName = "Bond",
                MobileNo = "9521000025",
                Email = "James007@gmail.com"
            };

            var vSubList = new List<Employee>
        {
                vSubOne, vSubTwo,
                vSubThree, vSubFour,
                vSubFive,vSubSix,
                vSubSeven
            };

            return vSubList;
        }
    }

	public class Employee
	{
		public long EmployeeId
		{ get; set; }

		public string FirstName
		{ get; set; }

		public string LastName
		{ get; set; }

		public string FullName
		{
			get
			{
				return FirstName + " " + LastName;
			}
		}
		public string MobileNo
		{ get; set; }
		public string Email
		{ get; set; }

	}

}
