using amaris.web.api.core.dto;
using amaris.web.api.core.interfaces.services;

namespace amaris.web.api.test
{
    public class Tests
    {
        private IEmployeeService _service;
        public Tests(IEmployeeService service)
        {
            _service = service;
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetAllEmployees()
        {
            try
            {
                var result = _service.Get();

                if (((List<Employee>)result.Content).Count() == 0)
                {
                    Assert.Fail();
                    return;
                }

                Assert.Pass();
            }
            catch (Exception)
            {
                Assert.Fail();
            }


        }
        [Test]
        public void GetOneEmployee()
        {
            try
            {
                var result = _service.Get(20);

                if (((Employee)result.Content)==null)                {
                    Assert.Fail();
                    return;
                }

                Assert.Pass();
            }
            catch (Exception)
            {
                Assert.Fail();
            }


        }
    }
}