using SampleRestAPI.Models;
using System.Collections.Generic;

namespace SampleRestAPI.Repositories
{
    interface IPersonRepository
    {

        List<Person> Get();

        Person Get(int id);

        Person Post(Person person);

        Person Put(Person person);

        Person Delete(Person person);

        void Delete(int id);

    }
}
