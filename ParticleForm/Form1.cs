using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfaces;
using Factory;

namespace ParticleForm
{
    /// <summary>
    /// The main particle UI.
    /// </summary>
    public partial class Form1 : Form
    {
        public IParticle particle { get; set; } // UI values are stored in this object
        public List<IParticle> particles = new List<IParticle>(); // List of particles stored in UI grid

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// determines if particle is fermion or boson
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            particle = Factory<IParticle>.Create(type.Text);
        }

        /// <summary>
        /// Read values from form into particle.
        /// </summary>
        private void SetParticle()
        {
            if (particle==null)
            {
                particle = Factory<IParticle>.Create(type.Text);
            }
            particle.mass = mass.Value;
            particle.spin = spin.Value;
            particle.name = name.Text;
            particle.charge = charge.Value;
        }

        /// <summary>
        /// Validate and add particle to grid and database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                // put form values in particle
                SetParticle();

                // check if values are valid
                particle.Validate();

                // update grid and database
                AddParticleToGrid();

                IDataBase<IParticle> dal = Factory<IDataBase<IParticle>>.Create("ParticleDAL");
                dal.Add(particle); // add to memory
                dal.Save(); // add to database (disabled for this example but all the code is still there.)
            }
            catch (Exception ex)
            {
                // Validation failed print error message.
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Add current particle to UI grid
        /// </summary>
        private void AddParticleToGrid()
        {
            // missing factory copy method
            IParticle obj = Factory<IParticle>.Create(type.Text);
            obj.CopyValues(particle);
            particles.Add(obj);
            GridView.DataSource = new List<IParticle>(particles);
        }

        /// <summary>
        /// Display README information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReadmeButton_Click(object sender, EventArgs e)
        {
            string readMeTxt = @"Welcome to the Elementary Particle Information Database! 

To add a new particle, fill out the form and click Add.

This program was created by Nicholas P. Brawand, as a work sample for the position of Tools Software Engineer at Electronic Arts in Orlando. This program was therefore written in C# using Windows Forms, multiple design patterns and various extras such as dependency injection containers to achieve a loosely-coupled design.

Author contact info:
nicholasbrawand@gmail.com
nicholasbrawand.com

Required: Unity Application Block, SQL Server 2016";
            MessageBox.Show(readMeTxt, "The Elementary Particle Information Database - README");
        }
    }
}
