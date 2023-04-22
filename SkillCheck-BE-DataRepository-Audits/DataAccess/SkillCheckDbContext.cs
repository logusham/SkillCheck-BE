using Microsoft.EntityFrameworkCore;
using SkillCheck_BE_Entities_Audits.Entities.Accounts;
using SkillCheck_BE_Entities_Audits.Entities.Audits;
using SkillCheck_BE_Entities_Audits.Entities.Master;

namespace SkillCheck_BE_DataRepository_Audits.DataAccess
{
    public class SkillCheckDbContext : DbContext
    {
        public SkillCheckDbContext(DbContextOptions<SkillCheckDbContext> options) : base(options)
        {

        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Technology> Technologies { get; set; }
        public DbSet<Audit> Audits { get; set; }
        public DbSet<AuditCheck> AuditChecks { get; set; }
        public DbSet<Batch> Batches { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<UserAuditCheck> UserAuditChecks { get; set; }
        public DbSet<CheckQuestion> CheckQuestions { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<AuditWeight> AuditWeights { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Capability> Capabilities { get; set; }
        public DbSet<JobRole> JobRoles { get; set; }
        public DbSet<Competency> Competencies { get; set; }
        public DbSet<Proficiency> Proficiencies { get; set; }
        public DbSet<UserAuthenticationCredential> UserAuthenticationCredentials { get; set; }
        public DbSet<Question> Questions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne(u => u.Customer)
                .WithMany()
                .HasForeignKey(u => u.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CheckQuestion>()
                .HasOne(u => u.Topic)
                .WithMany()
                .HasForeignKey(u => u.TopicId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AuditCheck>()
               .HasOne(u => u.ExpectedProficiency)
               .WithMany()
               .HasForeignKey(u => u.ExpectedProficiencyId)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UserAuditCheck>()
               .HasOne(u => u.UserProficiency)
               .WithMany()
               .HasForeignKey(u => u.UserProficiencyId)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Audit>()
              .HasOne(u => u.ReviewForUser)
              .WithMany(z => z.Audits)
              .HasForeignKey(u => u.ReviewForUserId)
              .OnDelete(DeleteBehavior.Restrict);

/*            modelBuilder.Entity<Audit>()
              .HasOne(u => u.ReviewByUser)
              .WithOne(z => z.Audits)
              .HasForeignKey(u => u.ReviewByUserId)
              .OnDelete(DeleteBehavior.Cascade);*/


            modelBuilder
                .Entity<Account>()
                .Property(a => a.AccountType)
                .HasConversion(
                 v => v.ToString(),
                 v => (AccountType)Enum.Parse(typeof(AccountType), v));

            modelBuilder
               .Entity<Customer>()
               .Property(a => a.CustomerType)
               .HasConversion(
                v => v.ToString(),
                v => (CustomerType)Enum.Parse(typeof(CustomerType), v));

            modelBuilder
              .Entity<User>()
              .Property(b => b.UserType)
              .HasConversion(
               v => v.ToString(),
               v => (UserType)Enum.Parse(typeof(UserType), v));

            modelBuilder
              .Entity<Audit>()
              .Property(a => a.AuditType)
              .HasConversion(
               v => v.ToString(),
               v => (AuditType)Enum.Parse(typeof(AuditType), v));

            modelBuilder
              .Entity<Audit>()
              .Property(a => a.AuditStatus)
              .HasConversion(
               v => v.ToString(),
               v => (AuditStatus)Enum.Parse(typeof(AuditStatus), v));

            modelBuilder
              .Entity<Audit>()
              .Property(a => a.CompetencyCategory)
              .HasConversion(
               v => v.ToString(),
               v => (CompetencyCategory)Enum.Parse(typeof(CompetencyCategory), v));

            modelBuilder
              .Entity<Proficiency>()
              .Property(a => a.ProficiencyType)
              .HasConversion(
               v => v.ToString(),
               v => (ProficiencyType)Enum.Parse(typeof(ProficiencyType), v));

            modelBuilder
              .Entity<AuditCheck>()
              .Property(a => a.Priority)
              .HasConversion(
               v => v.ToString(),
               v => (Priority)Enum.Parse(typeof(Priority), v));

            modelBuilder
              .Entity<AuditCheck>()
              .Property(a => a.ExperienceBand)
              .HasConversion(
               v => v.ToString(),
               v => (ExperienceBand)Enum.Parse(typeof(ExperienceBand), v));

            modelBuilder
              .Entity<AuditCheck>()
              .Property(a => a.Level)
              .HasConversion(
               v => v.ToString(),
               v => (Level)Enum.Parse(typeof(Level), v));

            modelBuilder
                .Entity<AuditCheck>()
                .HasOne(x => x.Technology)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder
              .Entity<UserAuthenticationCredential>()
              .Property(a => a.AuthenticationMode)
              .HasConversion(
               v => v.ToString(),
               v => (AuthenticationMode)Enum.Parse(typeof(AuthenticationMode), v));

            modelBuilder
              .Entity<UserAuthenticationCredential>()
              .Property(a => a.AuthenticationSource)
              .HasConversion(
               v => v.ToString(),
               v => (AuthenticationSource)Enum.Parse(typeof(AuthenticationSource), v));

            SeedData(modelBuilder);


        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            Technology tech1 = new Technology()
            {
                Code = "Tech1",
                IsActive = true,
                TechnologyId = 1,
                Title = "DotNet",
                CreatedBy = "Admin",
            };

            Technology tech2 = new Technology()
            {
                Code = "Java",
                IsActive = true,
                TechnologyId = 2,
                Title = "TechTitle2",
                CreatedBy = "Admin",
            };

            Technology tech3 = new Technology()
            {
                Code = "Tech3",
                IsActive = true,
                TechnologyId = 3,
                Title = "Angular",
                CreatedBy = "Admin",
            };

            //Technology tech4 = new Technology()
            //{
            //    Code = "Tech4",
            //    IsActive = true,
            //    TechnologyId = 4,
            //    Title = "HTML",
            //    CreatedBy = "Admin",
            //};
            //Technology tech5 = new Technology()
            //{
            //    Code = "Tech5",
            //    IsActive = true,
            //    TechnologyId = 5,
            //    Title = "React",
            //    CreatedBy = "Admin",
            //};
            //Technology tech6 = new Technology()
            //{
            //    Code = "Tech6",
            //    IsActive = true,
            //    TechnologyId = 6,
            //    Title = "Python",
            //    CreatedBy = "Admin",
            //};
            //Technology tech7 = new Technology()
            //{
            //    Code = "Tech7",
            //    IsActive = true,
            //    TechnologyId = 7,
            //    Title = "Cpp",
            //    CreatedBy = "Admin",
            //};

            //Technology tech8 = new Technology()
            //{
            //    Code = "Tech8",
            //    IsActive = true,
            //    TechnologyId = 8,
            //    Title = "Nodejs",
            //    CreatedBy = "Admin",
            //};

            //Technology tech9 = new Technology()
            //{
            //    Code = "Tech9",
            //    IsActive = true,
            //    TechnologyId = 9,
            //    Title = "JavaScript",
            //    CreatedBy = "Admin",
            //};

            //Technology tech10 = new Technology()
            //{
            //    Code = "Tech10",
            //    IsActive = true,
            //    TechnologyId = 10,
            //    Title = "SQL",
            //    CreatedBy = "Admin",
            //};

            Customer customer1 = new Customer
            {
                CustomerId = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                CustomerType = CustomerType.PARTNER,
                IsActive = true,
                Title = "CTitle1",
                Code = "CCode1",
                CreatedBy = "Admin"
            };

            Customer customer2 = new Customer
            {
                CustomerId = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                CustomerType = CustomerType.PARTNER,
                IsActive = true,
                Title = "CTitle2",
                Code = "CCode2",
                CreatedBy = "Admin"
            };

            Customer customer3 = new Customer
            {
                CustomerId = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                CustomerType = CustomerType.PARTNER,
                IsActive = true,
                Title = "CTitle3",
                Code = "CCode3",
                CreatedBy = "Admin"
            };

            Customer customer4 = new Customer
            {
                CustomerId = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                CustomerType = CustomerType.PARTNER,
                IsActive = true,
                Title = "CTitle4",
                Code = "CCode4",
                CreatedBy = "Admin"
            };

            Customer customer5 = new Customer
            {
                CustomerId = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                CustomerType = CustomerType.PARTNER,
                IsActive = true,
                Title = "CTitle5",
                Code = "CCode5",
                CreatedBy = "Admin"
            };

            Customer customer6 = new Customer
            {
                CustomerId = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                CustomerType = CustomerType.PARTNER,
                IsActive = true,
                Title = "CTitle6",
                Code = "CCode6",
                CreatedBy = "Admin"
            };

            Customer customer7 = new Customer
            {
                CustomerId = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                CustomerType = CustomerType.PARTNER,
                IsActive = true,
                Title = "CTitle7",
                Code = "CCode7",
                CreatedBy = "Admin"
            };

            Customer customer8 = new Customer
            {
                CustomerId = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                CustomerType = CustomerType.PARTNER,
                IsActive = true,
                Title = "CTitle8",
                Code = "CCode8",
                CreatedBy = "Admin"
            };

            Customer customer9 = new Customer
            {
                CustomerId = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                CustomerType = CustomerType.PARTNER,
                IsActive = true,
                Title = "CTitle9",
                Code = "CCode9",
                CreatedBy = "Admin"
            };

            Customer customer10 = new Customer
            {
                CustomerId = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                CustomerType = CustomerType.PARTNER,
                IsActive = true,
                Title = "CTitle10",
                Code = "CCode10",
                CreatedBy = "Admin"
            };

            Module modules1 = new Module
            {
                Code = "MCode1",
                IsActive = true,
                ModuleID = 1,
                Title = "Programming with .NET",
            };

            Module modules2 = new Module
            {
                Code = "MCode2",
                IsActive = true,
                ModuleID = 2,
                Title = "Thinking in Objects"
            };

            Module modules3 = new Module
            {
                Code = "MCode3",
                IsActive = true,
                ModuleID = 3,
                Title = "Database Essentials"
            };

            Module modules4 = new Module
            {
                Code = "MCode4",
                IsActive = true,
                ModuleID = 4,
                Title = "Devops"
            };

            Module modules5 = new Module
            {
                Code = "MCode5",
                IsActive = true,
                ModuleID = 5,
                Title = "C# Programming"
            };

            

            Unit unit1 = new Unit
            {
                Code = "UCode1",
                UnitId = 1,
                IsActive = true,
                Title = "Web Essentials"
            };

            Unit unit2 = new Unit
            {
                Code = "UCode2",
                UnitId = 2,
                IsActive = true,
                Title = ".Net Fundamentals"
            };

            Unit unit3 = new Unit
            {
                Code = "UCode3",
                UnitId = 3,
                IsActive = true,
                Title = "C# Fundamentals"
            };



            Unit unit4 = new Unit
            {
                Code = "UCode4",
                UnitId = 4,
                IsActive = true,
                Title = "Case Study - Guided Exercises and Do It Yourself"
            };
            Unit unit5 = new Unit
            {
                Code = "UCode5",
                UnitId = 5,
                IsActive = true,
                Title = "Transitioning from Procedural approach to Object-Oriented approach"
            };

            Unit unit6 = new Unit
            {
                Code = "UCode6",
                UnitId = 6,
                IsActive = true,
                Title = "A first look at OO Programming in C#"
            };

            Unit unit7 = new Unit
            {
                Code = "UCode7",
                UnitId = 7,
                IsActive = true,
                Title = "A first look at OO Programming in C#"
            };

            Unit unit8 = new Unit
            {
                Code = "UCode8",
                UnitId = 8,
                IsActive = true,
                Title = "Introduction to Database"
            };

            Unit unit9 = new Unit
            {
                Code = "UCode9",
                UnitId = 9,
                IsActive = true,
                Title = "E-R Modelling"
            };


            Unit unit10 = new Unit
            {
                Code = "UCode10",
                UnitId = 10,
                IsActive = true,
                Title = "RDBMS and Basic SQL"
            };

            Unit unit11 = new Unit
            {
                Code = "UCode11",
                UnitId = 11,
                IsActive = true,
                Title = "Joins, Sub queries, Views"
            };

            Unit unit12 = new Unit
            {
                Code = "UCode12",
                UnitId = 12,
                IsActive = true,
                Title = "Abstract Classes and Interfaces"
            };

            Unit unit13 = new Unit
            {
                Code = "UCode13",
                UnitId = 13,
                IsActive = true,
                Title = "Web Essentials"
            };

            Unit unit14 = new Unit
            {
                Code = "UCode14",
                UnitId = 14,
                IsActive = true,
                Title = "Jenkins"
            };

            Batch batch1 = new Batch
            {
                BatchId = Guid.NewGuid(),
                StartDate = DateTime.Now,
                Code = "Batch1",
                IsActive = true,
                Title = "IBH",
                CreatedBy = "Admin",
            };

            Batch batch2 = new Batch
            {
                BatchId = Guid.NewGuid(),
                StartDate = DateTime.Now,
                Code = "Batch2",
                IsActive = true,
                Title = "SALP",
                CreatedBy = "Admin",
            };

            Batch batch3 = new Batch
            {
                BatchId = Guid.NewGuid(),
                StartDate = DateTime.Now,
                Code = "Batch3",
                IsActive = true,
                Title = "Interview Readiness",
                CreatedBy = "Admin",
            };

            Batch batch4 = new Batch
            {
                BatchId = Guid.NewGuid(),
                StartDate = DateTime.Now,
                Code = "Batch4",
                IsActive = true,
                Title = "Angular",
                CreatedBy = "Admin",
            };

            Batch batch5 = new Batch
            {
                BatchId = Guid.NewGuid(),
                StartDate = DateTime.Now,
                Code = "Batch5",
                IsActive = true,
                Title = "Java",
                CreatedBy = "Admin",

            };
            User user1 = new User
            {
                UserID = Guid.NewGuid(),
                Email = "karthik@gmail.com",
                IsActive = true,
                Name = "Karthik",
                MobileNo = "9762354324"
            };



            User user2 = new User
            {
                UserID = Guid.NewGuid(),
                Email = "mahesh@gmail.com",
                IsActive = true,
                Name = "Mahesh",
                MobileNo = "9876543211"
            };



            User user3 = new User
            {
                UserID = Guid.NewGuid(),
                Email = "Lakshman@gmail.com",
                IsActive = true,
                Name = "Lakshman",
                MobileNo = "8965435643"
            };



            User user4 = new User
            {
                UserID = Guid.NewGuid(),
                Email = "prem@gmail.com",
                IsActive = true,
                Name = "Prem",
                MobileNo = "8972234569"
            };



            User user5 = new User
            {
                UserID = Guid.NewGuid(),
                Email = "Anuradha@gmail.com",
                IsActive = true,
                Name = "Anuradha",
                MobileNo = "7856456449"
            };
            User user6 = new User
            {
                UserID = Guid.NewGuid(),
                Email = "Kushbukumari@gmail.com",
                IsActive = true,
                Name = "Kushbu",
                MobileNo = "7856563432"
            };

            User user7 = new User
            {
                UserID = Guid.NewGuid(),
                Email = "ramya234@gmail.com",
                IsActive = true,
                Name = "Ramya",
                MobileNo = "9976886548"
            };

            User user8 = new User
            {
                UserID = Guid.NewGuid(),
                Email = "subhiksha@gmail.com",
                IsActive = true,
                Name = "Subhiksha",
                MobileNo = "456734999"
            };

            User user9 = new User
            {
                UserID = Guid.NewGuid(),
                Email = "Ar12@gmail.com",
                IsActive = true,
                Name = "Anusha",
                MobileNo = "9967439021"
            };

            User user10 = new User
            {
                UserID = Guid.NewGuid(),
                Email = "Anu3312@gmail.com",
                IsActive = true,
                Name = "Anusha Ramesh",
                MobileNo = "9234439021"
            };

            Topic topic1 = new Topic
            {
                TopicID = 1,
                Code = "Topic1",
                IsActive = true,
                Title = "Topic Title1"
            };

            Topic topic2 = new Topic
            {
                TopicID = 2,
                Code = "Topic2",
                IsActive = true,
                Title = "Topic Title2"
            };

            Topic topic3 = new Topic
            {
                TopicID = 3,
                Code = "Topic3",
                IsActive = true,
                Title = "Topic Title3"
            };

            Question question1 = new Question
            {
                QuestionID = 1,
                Title = "Difference between Array and ArrayList",
                Code = "titlecode1",
                IsActive = true,
                CreatedBy = "Admin",
                KnowledgeAreaTags = "Collections",
                CompetencyTags = "",
                TopicId = 1
            };

            Question question2 = new Question
            {
                QuestionID = 2,
                Title = "Difference between Interface and Abstraction",
                Code = "titlecode1",
                IsActive = true,
                CreatedBy = "Admin",
                KnowledgeAreaTags = "Oops",
                CompetencyTags = "",
                TopicId = 1
            };

            Question question3 = new Question
            {
                QuestionID = 3,
                Title = "What is C#",
                Code = "titlecode1",
                IsActive = true,
                CreatedBy = "Admin",
                KnowledgeAreaTags = "C# Programming",
                CompetencyTags = "",
                TopicId = 2
            };

            Question question4 = new Question
            {
                QuestionID = 4,
                Title = "What is polymorphism",
                Code = "titlecode1",
                IsActive = true,
                CreatedBy = "Admin",
                KnowledgeAreaTags = "Oops",
                CompetencyTags = "",
                TopicId = 2
            };

            Question question5 = new Question
            {
                QuestionID = 5,
                Title = "",
                Code = "What is encapsulation",
                IsActive = true,
                CreatedBy = "Admin",
                KnowledgeAreaTags = "Oops",
                CompetencyTags = "",
                TopicId = 3
            };

            CheckQuestion checkQuestion1 = new CheckQuestion
            {
                CheckId = 1,
                IsActive = true,
                Tags = "tag1",
                TopicId = 1,
                CreatedBy = "Admin",
                QuestionId = 1,
                
            };

            CheckQuestion checkQuestion2 = new CheckQuestion
            {
                CheckId = 2,
                IsActive = true,
                Tags = "tag2",
                TopicId = 1,
                CreatedBy = "Admin",
                QuestionId = 2
            };

            CheckQuestion checkQuestion3 = new CheckQuestion
            {
                CheckId = 3,
                IsActive = true,
                Tags = "tag3",
                TopicId = 2,
                CreatedBy = "Admin",
                QuestionId = 3
            };

            CheckQuestion checkQuestion4 = new CheckQuestion
            {
                CheckId = 4,
                IsActive = true,
                Tags = "tag4",
                TopicId = 2,
                CreatedBy = "Admin",
                QuestionId = 4

            };

            CheckQuestion checkQuestion5 = new CheckQuestion
            {
                CheckId = 5,
                IsActive = true,
                Tags = "tag5",
                TopicId = 3,
                CreatedBy = "Admin",
                QuestionId = 5
            };

            AuditWeight auditWeight1 = new AuditWeight
            {
                ID = 1,
                Code = "AW1",
                Weight = 1
            };

            AuditWeight auditWeight2 = new AuditWeight
            {
                ID = 2,
                Code = "AW2",
                Weight = 2
            };

            AuditWeight auditWeight3 = new AuditWeight
            {
                ID = 3,
                Code = "AW3",
                Weight = 3
            };

            Proficiency defaultProficiency1 = new Proficiency
            {
                ProficiencyID = 1,
                Code = "DP1",
                IsActive = true,
                Title = "DPT1",
                ProficiencyType = ProficiencyType.CONCEPTUAL_UNDERSTANDING
            };

            Proficiency defaultProficiency2 = new Proficiency
            {
                ProficiencyID = 2,
                Code = "DP2",
                IsActive = true,
                Title = "DPT2",
                ProficiencyType = ProficiencyType.IMPLEMENTATION
            };

            Proficiency defaultProficiency3 = new Proficiency
            {
                ProficiencyID = 3,
                Code = "DP3",
                IsActive = true,
                Title = "DPT3",
                ProficiencyType = ProficiencyType.PROJECT
            };

            Proficiency expectedProficiency1 = new Proficiency
            {
                ProficiencyID = 4,
                Code = "EP1",
                IsActive = true,
                Title = "EPT1",
                ProficiencyType = ProficiencyType.CONCEPTUAL_UNDERSTANDING
            };

            Proficiency expectedProficiency2 = new Proficiency
            {
                ProficiencyID = 5,
                Code = "EP2",
                IsActive = true,
                Title = "EPT2",
                ProficiencyType = ProficiencyType.IMPLEMENTATION
            };

            Proficiency expectedProficiency3 = new Proficiency
            {
                ProficiencyID = 6,
                Code = "EP3",
                IsActive = true,
                Title = "EPT3",
                ProficiencyType = ProficiencyType.PROJECT
            };

            JobRole role1 = new JobRole
            {
                Code = "Role1",
                IsActive = true,
                JobRoleId = 1,
                Title = "JobTitle1"
            };

            JobRole role2 = new JobRole
            {
                Code = "Role2",
                IsActive = true,
                JobRoleId = 2,
                Title = "JobTitle2"
            };

            JobRole role3 = new JobRole
            {
                Code = "Role3",
                IsActive = true,
                JobRoleId = 3,
                Title = "JobTitle3"
            };

            JobRole role4 = new JobRole
            {
                Code = "Role4",
                IsActive = true,
                JobRoleId = 4,
                Title = "JobTitle4"
            };

            AuditCheck auditCheck1 = new AuditCheck
            {
                AuditCheckID = Guid.NewGuid(),
                IsActive = true,
                ExperienceBand = ExperienceBand.FRESHERS,
                Level = Level.BEGINNER,
                Priority = Priority.MUST_HAVE,
                AuditWeightId = auditWeight1.ID,
                CheckQuestionId = checkQuestion1.CheckId,
                TechnologyId = tech1.TechnologyId,
                ExpectedProficiencyId = expectedProficiency1.ProficiencyID,
                DefaultProficiencyId = defaultProficiency1.ProficiencyID,
                IsCheck=true,
            };

            AuditCheck auditCheck2 = new AuditCheck
            {
                AuditCheckID = Guid.NewGuid(),
                IsActive = true,
                ExperienceBand = ExperienceBand.FRESHERS,
                Level = Level.BEGINNER,
                Priority = Priority.MUST_HAVE,
                AuditWeightId = auditWeight2.ID,
                CheckQuestionId = checkQuestion2.CheckId,
                TechnologyId = tech1.TechnologyId,
                ExpectedProficiencyId = expectedProficiency2.ProficiencyID,
                DefaultProficiencyId = defaultProficiency2.ProficiencyID,
                IsCheck = true,
            };

            AuditCheck auditCheck3 = new AuditCheck
            {
                AuditCheckID = Guid.NewGuid(),
                IsActive = true,
                ExperienceBand = ExperienceBand.FRESHERS,
                Level = Level.BEGINNER,
                Priority = Priority.MUST_HAVE,
                AuditWeightId = auditWeight3.ID,
                CheckQuestionId = checkQuestion3.CheckId,
                TechnologyId = tech2.TechnologyId,
                ExpectedProficiencyId = expectedProficiency3.ProficiencyID,
                DefaultProficiencyId = defaultProficiency3.ProficiencyID,
                IsCheck = true,
            };

            AuditCheck auditCheck4 = new AuditCheck
            {
                AuditCheckID = Guid.NewGuid(),
                IsActive = true,
                ExperienceBand = ExperienceBand.FRESHERS,
                Level = Level.BEGINNER,
                Priority = Priority.MUST_HAVE,
                AuditWeightId = auditWeight1.ID,
                CheckQuestionId = checkQuestion4.CheckId,
                TechnologyId = tech2.TechnologyId,
                ExpectedProficiencyId = expectedProficiency2.ProficiencyID,
                DefaultProficiencyId = defaultProficiency3.ProficiencyID,
                IsCheck = true,
            };

            AuditCheck auditCheck5 = new AuditCheck
            {
                AuditCheckID = Guid.NewGuid(),
                IsActive = true,
                ExperienceBand = ExperienceBand.FRESHERS,
                Level = Level.BEGINNER,
                Priority = Priority.MUST_HAVE,
                AuditWeightId = auditWeight3.ID,
                CheckQuestionId = checkQuestion5.CheckId,
                TechnologyId = tech3.TechnologyId,
                ExpectedProficiencyId = expectedProficiency3.ProficiencyID,
                DefaultProficiencyId = defaultProficiency1.ProficiencyID,
                IsCheck = true,
            };

            Audit audit1 = new Audit
            {
                AuditID = Guid.NewGuid(),
                Title = "title1",
                Code = "code1",
                IsActive = true,
                AuditType = AuditType.PEER,
                CompetencyCategory = CompetencyCategory.PROFESSIONAL,
                TechnologyId = 1,
                AuditStatus = AuditStatus.PUBLISH,
            };
            
            Audit audit2 = new Audit
            {
                AuditID = Guid.NewGuid(),
                Title = "title2",
                Code = "code2",
                IsActive = true,
                AuditType = AuditType.PEER,
                CompetencyCategory = CompetencyCategory.PROFESSIONAL,
                TechnologyId = 1,
                AuditStatus = AuditStatus.PUBLISH,
            };
            
            Audit audit3 = new Audit
            {
                AuditID = Guid.NewGuid(),
                Title = "title1",
                Code = "code1",
                IsActive = true,
                AuditType = AuditType.PEER,
                CompetencyCategory = CompetencyCategory.PROFESSIONAL,
                TechnologyId = 1,
                AuditStatus = AuditStatus.PUBLISH,
            };




            tech1.BatchId = batch1.BatchId;
            tech2.BatchId = batch2.BatchId;
            tech3.BatchId = batch3.BatchId;


            modules1.TechnologyId = tech1.TechnologyId;
            modules2.TechnologyId = tech2.TechnologyId;
            modules3.TechnologyId = tech3.TechnologyId;
            modules4.TechnologyId = tech1.TechnologyId;
            modules5.TechnologyId = tech2.TechnologyId;

            unit1.ModuleId = 1;
            unit2.ModuleId = 1;
            unit3.ModuleId = 2;
            unit4.ModuleId = 2;
            unit5.ModuleId = 3;
            unit6.ModuleId = 3;
            unit7.ModuleId = 3;
            unit8.ModuleId = 4;
            unit9.ModuleId = 4;
            unit10.ModuleId = 5;
            unit11.ModuleId = 5;
            unit12.ModuleId = 5;
            unit13.ModuleId = 5;
            unit14.ModuleId = 5;

            batch1.CustomerId = customer1.CustomerId;
            batch2.CustomerId = customer2.CustomerId;
            batch3.CustomerId = customer3.CustomerId;
            batch4.CustomerId = customer4.CustomerId;
            batch5.CustomerId = customer5.CustomerId;

            user1.BatchId = batch1.BatchId;
            user1.CustomerId = customer1.CustomerId;
            user2.BatchId = batch2.BatchId;
            user2.CustomerId = customer2.CustomerId;
            user3.BatchId = batch3.BatchId;
            user3.CustomerId = customer3.CustomerId;
            user4.BatchId = batch4.BatchId;
            user4.CustomerId = customer4.CustomerId;
            user5.BatchId = batch5.BatchId;
            user5.CustomerId = customer5.CustomerId;

            topic1.UnitId = 1;
            topic2.UnitId = 1;
            topic3.UnitId = 2;

            question1.TopicId = 1;
            question2.TopicId = 1;
            question3.TopicId = 2;
            question4.TopicId = 2;
            question5.TopicId = 3;

            modelBuilder.Entity<Technology>().HasData(tech1, tech2, tech3);
            modelBuilder.Entity<Customer>().HasData(customer1, customer2, customer3, customer4, customer5, customer6, customer7, customer8, customer9, customer10);
            modelBuilder.Entity<User>().HasData(user1, user2, user3, user4, user5);
            modelBuilder.Entity<Batch>().HasData(batch1, batch2, batch3, batch4, batch5);
            modelBuilder.Entity<Module>().HasData(modules1, modules2, modules3, modules4, modules5);
            modelBuilder.Entity<Unit>().HasData(unit1, unit2, unit3, unit4, unit5, unit10, unit11, unit12, unit13, unit14, unit6, unit7, unit8, unit9);
            modelBuilder.Entity<Topic>().HasData(topic1, topic2, topic3);
            modelBuilder.Entity<Question>().HasData(question1, question2, question3, question4, question5);
            modelBuilder.Entity<CheckQuestion>().HasData(checkQuestion1, checkQuestion2, checkQuestion3, checkQuestion4, checkQuestion5);
            modelBuilder.Entity<AuditWeight>().HasData(auditWeight1, auditWeight2, auditWeight3);
            modelBuilder.Entity<Proficiency>().HasData(defaultProficiency1, defaultProficiency2, defaultProficiency3, expectedProficiency1, expectedProficiency2, expectedProficiency3);
            modelBuilder.Entity<AuditCheck>().HasData(auditCheck1, auditCheck2, auditCheck3, auditCheck4, auditCheck5);
        }
    }
}
