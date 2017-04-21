using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    /// <summary>
    /// Base data layer class for database.
    /// </summary>
    /// <typeparam name="Type"></typeparam>
    public class DataLayer<Type> : IDataBase<Type>
    {
        protected List<Type> objs = new List<Type>(); // data layer objects
        protected string connection; // connection string to database

        public DataLayer(string _connection)
        {
            connection = _connection;
        }

        public void Add(Type particle)
        {
            objs.Add(particle);
        }

        public virtual void Save()
        {
            throw new NotImplementedException();

        }
    }

    /// <summary>
    /// Template class for all sql commands
    /// </summary>
    /// <typeparam name="Type"></typeparam>
    public abstract class CommandTemplate<Type> : DataLayer<Type>
    {
        protected SqlConnection sqlConnection = null;
        protected SqlCommand sqlCommand = null;

        public CommandTemplate(string _connection):base(_connection)
        {

        }
           
        /// <summary>
        /// Open connection, run sql command and close connection
        /// </summary>
        /// <param name="obj"></param>
        private void RunCommand(Type obj)
        {
            try
            {
                Open();
                Execute(obj);
                Close();
            }
            catch
            {
                Console.WriteLine("I chose to disable saving entries to the database for this example.");
                Console.WriteLine("You can enable this feature by creating a database, supplying the correct " +
                    "path to your DB in Factory.cs and replacing particleTable below with the correct table name.");
            }
        }

        /// <summary>
        /// Open connection and prepare command.
        /// </summary>
        private void Open()
        {
            sqlConnection = new SqlConnection(connection);
            sqlConnection.Open();
            sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
        }

        /// <summary>
        /// execute sqlCommand, the specifics implemented by children
        /// </summary>
        /// <param name="obj"></param>
        public abstract void Execute(Type obj);

        /// <summary>
        /// Close connection to database.
        /// </summary>
        private void Close()
        {
            sqlConnection.Close();
        }

        /// <summary>
        /// Run sql commands for every object.
        /// </summary>
        public override void Save()
        {
            foreach (Type obj in objs)
            {
                RunCommand(obj);
            }
        }
    }

    /// <summary>
    /// Specific sql commands for the particle class.
    /// </summary>
    public class ParticleDataLayer : CommandTemplate<IParticle>
    {
        public ParticleDataLayer(string _connection) : base(_connection)
        {
        }

        /// <summary>
        /// Add particle to database.
        /// </summary>
        /// <param name="obj"></param>
        public override void Execute(IParticle obj)
        {
            // These database inputs should be clean.
            sqlCommand.CommandText = "insert into particleTable("+
                                            "Name,Spin,Charge,Mass) "+
                                            "values('"+
                                            obj.name+"','"+obj.spin+"','"+obj.charge+"','"+obj.mass+"')";
   
             sqlCommand.ExecuteNonQuery();

        }
    }

}
