using System;

namespace Project_24_Interface;

// bu class ı ileride olusturacağım product, category,customer gibi farklı yapılar için miras vermek üzere olusturuyorum.

public abstract class Repo
{
        public abstract void Create();
        public abstract void GetAll();
        public abstract void GetById();
        public abstract void Update();
        public abstract void Delete();


    public class ProductRepo : Repo // tek tek yazma ctrl.
    {
        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override void GetAll()
        {
            throw new NotImplementedException();
        }

        public override void GetById()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }

    public class CategoryRepo : Repo
    {
        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override void GetAll()
        {
            throw new NotImplementedException();
        }

        public override void GetById()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }



}
