using UpworkDemo.Models;

namespace UpworkDemo.Services;

public static class JobService
{
	private static List<Job> Jobs;

	public static List<Job> GetJobs()
	{
		Jobs = new List<Job>()
		{
			new Job()
			{
				Id = "01J3AGFKWPSWYBW9ZNM20033KF",
                Title = "Web Developer for Quality Platform",
				Description = "We are seeking a skilled web developer to build a high-quality platform for people with dreams. The platform will provide users with a space to connect, share ideas, and collaborate on projects. As the web developer, you will be responsible for designing and implementing the platform, ensuring it is user-friendly, responsive, and visually appealing. You will work closely with the project manager and UI/UX designer to ensure that the platform meets the requirements and aligns with the overall vision.\n\nSkills needed:\n- Proficiency in HTML, CSS, and JavaScript\n- Experience with front-end frameworks like React or Angular\n- Understanding of back-end technologies such as Node.js or Python\n- Knowledge of database systems like MySQL or MongoDB\n- Strong problem-solving and debugging skills\nClick to apply:https://my5353.com/s4vjd\nThis is a medium-sized project with an estimated duration of 3 to 6 months. We are looking for an intermediate-level web developer with proven experience in building robust and user-friendly platforms.",
				ClientRating = 0,
				IsClientPaymentVerified = false,
				ProposalCount = 4,
				ClientSpent = 0,
				Tags = new List<string>(){ "Web Development", "Javascript", "WordPress", "HTML", "Web Design" },
				Location = "United States",
				WorkType = Enums.WorkTypeEnums.FixedPrice,
				Price = 420,
				Level = Enums.DeveloperLevelEnums.Intermediate,
				CreatedDate = new DateTime(2024,07,21,18,24,30),
                ShowClientSpent = true
            },
            new Job()
            {
                Id = "01J3AGK8NDM9JWRM4974NP0VM8",
                Title = "Need to reskin an existing working Vue.js UI",
                Description = "I have a working UI that is done in vue.js.\nIt was using bootstrap.\n\nI need to convert the theme to a vue.js theme.\n\nIt is a small portal with about 10 pages and mostly table pages.\n\nWe can keep the same API integration.",
                ClientRating = 4.27,
                IsClientPaymentVerified = true,
                ProposalCount = 13,
                ClientSpent = 0,
                Tags = new List<string>(){ "Vue.js" },
                Location = "Hong Kong",
                WorkType = Enums.WorkTypeEnums.FixedPrice,
                Price = 100,
                Level = Enums.DeveloperLevelEnums.Intermediate,
                CreatedDate = new DateTime(2024,07,21,06,24,30)
            },
             new Job()
            {
                Id = "01J3AGW7WZVEX2N7H20XABS55Z",
                Title = "Work on Nestjs, Nodejs and mongo",
                Description = "Some work on backend such as\n\n1. Update Social login passport to return expected response (api implementation)\n2. Create schema models in backend and write apis\n3. Update api\n4. Comments api response\n\nUse skills where required",
                ClientRating = 4.87,
                IsClientPaymentVerified = true,
                ProposalCount = 13,
                ClientSpent = 1500,
                Tags = new List<string>(){ "GraphQL", "Node.js", "MongoDB", "ExpressJS", "RESTful API", "Javascript", "Apollo.io" },
                Location = "India",
                WorkType = Enums.WorkTypeEnums.FixedPrice,
                Price = 15,
                Level = Enums.DeveloperLevelEnums.Expert,
                CreatedDate = new DateTime(2024,07,21,13,24,30)
            },
             new Job()
            {
                Id = "01J3AH1NPGW54535A0NN28QH9B",
                Title = "Log In System Enhancement",
                Description = "We are seeking a talented developer to enhance our existing log in system. The goal is to implement two-factor authentication (2FA) and an automatic pop-up feature. The system is currently built using C# and JavaScript in .NET, so experience with these technologies is essential. This project requires someone with a strong understanding of security protocols and authentication methods.\n\n   Key Skills:\n   - C# programming\n   - JavaScript development\n   - .NET framework\n   - Security protocols\n   - Authentication methods\n\n   If you have a proven track record of successfully implementing 2FA and enhancing user authentication systems, we would love to hear from you. This is a great opportunity to make a significant impact on our platform's security. Please include your relevant experience and examples of previous work in your application.",
                ClientRating = 5.00,
                IsClientPaymentVerified = true,
                ProposalCount = 13,
                ClientSpent = 100,
                Tags = new List<string>(){ "Microsoft SQL Server", "Javascript" },
                Location = "HKG",
                WorkType = Enums.WorkTypeEnums.FixedPrice,
                Price = 500,
                Level = Enums.DeveloperLevelEnums.Intermediate,
                CreatedDate = new DateTime(2024,07,21,15,24,30)
            },
             new Job()
            {
                Id = "01J3AH7ET1B8YZ1NMTG2WJ9W5V",
                Title = "Front-End Angular Developer (Remaining features and Solve bugs)",
                Description = "Needs to hire 2 Freelancers\nWe are seeking an experienced Front-End Angular Developer to join our dynamic team. As a Front-End Angular Developer, you will be responsible for designing, developing, and maintaining web applications using the Angular framework.\n\nKey Responsibilities:\n-Develop and implement user interfaces and features using Angular, HTML, CSS, and TypeScript\n-Collaborate with back-end developers to integrate Angular applications with APIs and services\n-Optimize application performance and implement responsive design principles\n-Write clean, maintainable, and testable code following best practices and design patterns\n-Participate in agile development processes, including sprint planning, code reviews, and standup meetings\n-Troubleshoot and debug issues in the front-end codebase\n-Stay up-to-date with the latest Angular updates, tools, and best practices\n-Contribute to the continuous improvement of the front-end development process and standards\n\nRequired Skills and Experience:\n-Minimum 2-3 years of experience in Angular development\n-Proficient in TypeScript, HTML, and CSS\n-Solid understanding of Angular's core concepts, such as components, services, directives, and routing\n-Knowledge of web development best practices, including responsive design, accessibility, and performance optimization\n-Strong problem-solving and analytical skills\n-Ability to work collaboratively in a team environment\n-Excellent communication skills, both written and verbal\n\nNice-to-Have Skills:\n-Experience with Ionic or NativeScript for building mobile applications\n-Knowledge of continuous integration and deployment tools\n-Experience with UI/UX design principles",
                ClientRating = 0.0,
                IsClientPaymentVerified = true,
                ProposalCount = 35,
                ClientSpent = 100,
                Tags = new List<string>(){ "Microsoft SQL Server", "Javascript" },
                Location = "Saudi Arabia",
                WorkType = Enums.WorkTypeEnums.FixedPrice,
                Price = 100,
                Level = Enums.DeveloperLevelEnums.Intermediate,
                CreatedDate = new DateTime(2024,07,20,15,24,30)
            },
        };
		return Jobs;
    }
}

