// Group Name: ReservationX
// Team Members:
// Vaishnavi Barot(8975398)
// Naiya Patel(8939307)
// Harsh Patel(8976157)
// Ravneet Kaur(8876396)
// Harpreet Kaur(8970729)


using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Xml.Serialization;

namespace ReservationX
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class Seat
    {


        public bool TicketisBooked { get; set; }
        public String passangerFName { get; set; }
        public String passangerLName { get; set; }
        public String PassangerContactNumber { get; set; }

        public String toolText { get; set; }

    }



    public partial class MainWindow : Window
    {
        static Seat[] seats = new Seat[20];


        bool IsALLSelected;

        bool IsDetailsValids = false;




        public MainWindow()
        {

            InitializeComponent();
            initalizeSeats();
            selectSeats();
            showList();
        }

        private void selectSeats()
        {


            resultLabel.Content = System.AppDomain.CurrentDomain.BaseDirectory;

            List<int> RemainSeats = new List<int>();

            var XmlSerializerInt = new XmlSerializer(typeof(List<int>));
            using (var writer = new StreamWriter(@"" + System.AppDomain.CurrentDomain.BaseDirectory + "\\SampleDataInt.xml"))
            {
                XmlSerializerInt.Serialize(writer, RemainSeats);
            }


            for (int i = 0; i < RemainSeats.Count; i++)
            {


                if (i != RemainSeats.ElementAt(i))
                {
                    seats[i].TicketisBooked = true;
                    //seats[i].personFirstName = "Mike";
                    //seats[i].personLastName = "Benjamin";
                    updateSeats();


                }
            }

        }

        private void clearSeatsByName_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {

                if (seats[i].passangerFName == SelectorTextField.Text)
                {
                    seats[i].TicketisBooked = false;
                    seats[i].passangerFName = "Not ";
                    seats[i].passangerLName = "Reserved";
                    updateSeats();
                }
            }
        }

        private void initalizeSeats(bool selectAll)
        {
            for (int index = 0; index < 20; index++)
            {
                Seat seatforAll = seats[index] = new Seat();
                if (selectAll)
                {
                    seatforAll.TicketisBooked = true;
                    seatforAll.passangerFName = "Mike";
                    seatforAll.passangerLName = "Benjamin";
                }
                else
                {
                    seatforAll.TicketisBooked = false;
                    seatforAll.passangerFName = "Not ";
                    seatforAll.passangerLName = "Reserved";
                }
                Label temp01 = new Label();
                temp01 = selectLabel(index);
                if (seatforAll.TicketisBooked)
                {

                    temp01.Background = (Brush)new BrushConverter().ConvertFromString("#FF856B");

                }
                else if (!seatforAll.TicketisBooked)
                {

                    temp01.Background = (Brush)new BrushConverter().ConvertFromString("#6fff59");

                }
            }
        }
        private void initalizeSeats()
        {
            for (int index = 0; index < 20; index++)
            {
                Seat seat = seats[index] = new Seat();

            }
        }

        private void updateSeats()
        {
            for (int index = 0; index < 20; index++)
            {

                if (seats[index].TicketisBooked)
                {
                    Label temp02 = new Label();
                    temp02 = selectLabel(index);
                    temp02.Background = (Brush)new BrushConverter().ConvertFromString("#FF856B");

                }

                else if (!seats[index].TicketisBooked)
                {
                    Label temp03 = new Label();
                    temp03 = selectLabel(index);
                    temp03.Background = (Brush)new BrushConverter().ConvertFromString("#6fff59");

                }



            }
        }


        private string seatName(int index)
        {
            string labelforSeat = "";
            switch (index)
            {

                case 1:
                    labelforSeat = "A";
                    break;

                case 2:
                    labelforSeat = "B";
                    break;

                case 3:
                    labelforSeat = "C";
                    break;

                case 4:
                    labelforSeat = "D";
                    break;

                case 5:
                    labelforSeat = "E";
                    break;

                case 6:
                    labelforSeat = "F";
                    break;

                case 7:
                    labelforSeat = "G";
                    break;

                case 8:
                    labelforSeat = "H";
                    break;

                case 9:
                    labelforSeat = "I";
                    break;

                case 10:
                    labelforSeat = "J";
                    break;

                case 11:
                    labelforSeat = "K";
                    break;

                case 12:
                    labelforSeat = "L";
                    break;

                case 13:
                    labelforSeat = "M";
                    break;

                case 14:
                    labelforSeat = "N";
                    break;

                case 15:
                    labelforSeat = "O";
                    break;

                case 16:
                    labelforSeat = "P";
                    break;

                case 17:
                    labelforSeat = "Q";
                    break;

                case 18:
                    labelforSeat = "R";
                    break;

                case 19:
                    labelforSeat = "S";
                    break;

                case 20:
                    labelforSeat = "T";
                    break;

            }
            return labelforSeat;

        }

        private Label selectLabel(int index)
        {
            Label selectedlabel = new Label();

            switch (index)
            {

                case 1:
                    selectedlabel = seatA;
                    break;

                case 2:
                    selectedlabel = seatB;
                    break;

                case 3:
                    selectedlabel = seatC;
                    break;

                case 4:
                    selectedlabel = seatD;
                    break;

                case 5:
                    selectedlabel = seatE;
                    break;

                case 6:
                    selectedlabel = seatF;
                    break;

                case 7:
                    selectedlabel = seatG;
                    break;

                case 8:
                    selectedlabel = seatH;
                    break;

                case 9:
                    selectedlabel = seatI;
                    break;

                case 10:
                    selectedlabel = seatJ;
                    break;

                case 11:
                    selectedlabel = seatK;
                    break;

                case 12:
                    selectedlabel = seatL;
                    break;

                case 13:
                    selectedlabel = seatM;
                    break;

                case 14:
                    selectedlabel = seatN;
                    break;

                case 15:
                    selectedlabel = seatO;
                    break;

                case 16:
                    selectedlabel = seatP;
                    break;

                case 17:
                    selectedlabel = seatQ;
                    break;

                case 18:
                    selectedlabel = seatR;
                    break;

                case 19:
                    selectedlabel = seatS;
                    break;

                case 20:
                    selectedlabel = seatT;
                    break;

            }
            return selectedlabel;
        }

        private void seat_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            for (int index = 1; index < 20; index++)
            {
                if (seats[index].TicketisBooked)
                {
                    Label label = selectLabel(index);
                    label.ToolTip = "Reserved By " + seats[index].passangerFName + seats[index].passangerLName;

                }

                else
                {
                    Label label = selectLabel(index);
                    label.ToolTip = "Not Reserved";
                }
            }

        }

        private void clearNumberedSeat_Click(object sender, RoutedEventArgs e)
        {
            if (clearSeatSelector.SelectedIndex > 1)
            {
                phoneTextField.Text = (clearSeatSelector.SelectedIndex - 1).ToString();
                error.Visibility = Visibility.Collapsed;
                seats[clearSeatSelector.SelectedIndex - 1].TicketisBooked = false;
                seats[clearSeatSelector.SelectedIndex - 1].passangerFName = "Not ";
                seats[clearSeatSelector.SelectedIndex - 1].passangerLName = "Rerserved";
                updateSeats();
            }
            else
            {

                error.Visibility = Visibility.Visible;
                error.Content = "Please Select a seat...";
            }

        }

        private void clearSeats_Click(object sender, RoutedEventArgs e)
        {
            initalizeSeats(false);

            //label.Content = "Hi, Choose Your Seat from below";
            label.Background = (Brush)new BrushConverter().ConvertFromString("#FFF");
        }

        private void seatSelector_Selected(object sender, RoutedEventArgs e)
        {
            phoneTextField.Text = seatSelector.Text;
        }

        private void reserveSeat_Click(object sender, RoutedEventArgs e)
        {
            //resultLable.Content = "Button Clicked";
            if (seatSelector.SelectedIndex > 0)
            {
                error.Visibility = Visibility.Collapsed;
                if (!IsALLSelected && IsDetailsValids)
                {


                    if (seats[seatSelector.SelectedIndex - 1].TicketisBooked)
                    {
                        success.Visibility = Visibility.Hidden;
                        error.Visibility = Visibility.Visible;
                        error.Content = "Sorry You cannot book that seat... It is reserved";
                    }
                    else
                    {
                        var travellersData = new List<Seat>();
                        seats[seatSelector.SelectedIndex - 1].TicketisBooked = true;
                        seats[seatSelector.SelectedIndex - 1].passangerFName = fNameTextField.Text;
                        seats[seatSelector.SelectedIndex - 1].passangerLName = lNameTextField.Text;
                        seats[seatSelector.SelectedIndex - 1].PassangerContactNumber = phoneTextField.Text;
                        //travellersList.Add(seats[seatSelector.SelectedIndex - 1]);

                        // XML Serialization 

                        List<int> emptySeats = new List<int>();

                        for (var i = 0; i < seats.Length; i++)
                        {
                            if (seats[i].TicketisBooked)
                            {
                                travellersData.Add(seats[i]);
                            }
                            else
                            {
                                emptySeats.Add(i);
                            }
                        }

                        var XmlSerializer = new XmlSerializer(typeof(List<Seat>));
                        using (var writer = new StreamWriter(@"" + System.AppDomain.CurrentDomain.BaseDirectory + "\\SampleData.xml"))
                        {
                            XmlSerializer.Serialize(writer, travellersData);
                        }

                        var XmlSerializerInt = new XmlSerializer(typeof(List<int>));
                        using (var writer = new StreamWriter(@"" + System.AppDomain.CurrentDomain.BaseDirectory + "\\SampleDataInt.xml"))
                        {
                            XmlSerializerInt.Serialize(writer, emptySeats);
                        }

                        updateSeats();

                        error.Visibility = Visibility.Hidden;
                        success.Visibility = Visibility.Visible;
                        showList();

                    }
                }
                else
                {
                    success.Visibility = Visibility.Hidden;
                    error.Visibility = Visibility.Visible;
                    error.Content = "Either all seats are booked or the details you entered are not valid";
                }
            }
            else
            {

                error.Visibility = Visibility.Visible;
                error.Content = "Please Select a seat...";
            }


        }

        private void showList()
        {
            /*for (int index = 0; index < 20; index++)
            {
                if (seats[index].isReserved)
                {
                    listing.Text = listing.Text + index + " Reserved By : " + seats[index].personFirstName + " " + seats[index].personLastName + "\n";
                }
            }*/

            // XML Deserializtion
            listing.Text = "";
            var XmlSerializer = new XmlSerializer(typeof(List<Seat>));
            List<Seat> visitors = new List<Seat>();

            using (var reader = new StreamReader(@"" + System.AppDomain.CurrentDomain.BaseDirectory + "\\SampleData.xml"))
            {
                visitors = (List<Seat>)XmlSerializer.Deserialize(reader);
                // Console.WriteLine(travellers.ToString());
                if (visitors != null)
                {
                    for (int index = 0; index < visitors.Count; index++)
                    {
                        listing.Text = listing.Text + index + " Booked By : " + visitors[index].passangerFName + " " + visitors[index].passangerLName + "\n";
                    }
                }
                else
                {
                    listing.Text = "No bookings yet";
                }
            }


        }

        private void filterButton_Click(object sender, RoutedEventArgs e)
        {
            listing.Text = "";
            var XmlSerializer = new XmlSerializer(typeof(List<Seat>));
            List<Seat> Visitors = new List<Seat>();

            using (var reader = new StreamReader(@"" + System.AppDomain.CurrentDomain.BaseDirectory + "\\SampleData.xml"))
            {
                Visitors = (List<Seat>)XmlSerializer.Deserialize(reader);

            }




            // resultLable.Content = listFilter.SelectedIndex;

            List<Seat> SortList = new List<Seat>();

            if (listFilter.SelectedIndex == 0)
            {
                SortList = Visitors.OrderBy(obj => obj.passangerFName).Reverse().ToList();
            }
            else if (listFilter.SelectedIndex == 2)
            {
                SortList = Visitors.OrderBy(obj => obj.passangerFName.Length).ToList();
            }
            else if (listFilter.SelectedIndex == 1)
            {

                var xmlSerializerInt = new XmlSerializer(typeof(List<int>));
                //List<Seat> travellers = new List<Seat>();

                using (var reader = new StreamReader(@"" + System.AppDomain.CurrentDomain.BaseDirectory + "\\SampleDataInt.xml"))
                {
                    var emptrySeats = (List<int>)xmlSerializerInt.Deserialize(reader);

                    List<int> DecendOrder = emptrySeats.OrderBy(obj => obj).Reverse().ToList();


                    for (int index = 0; index < DecendOrder.Count; index++)
                    {
                        //Label label = selectLabel(index);
                        int vacantListIndex = DecendOrder.ElementAt(index);

                        listing.Text = listing.Text + "Seat : " + seatName(vacantListIndex) + "\n";
                    }
                }

            }


            if (SortList != null)
            {
                for (int index = 0; index < SortList.Count; index++)
                {
                    listing.Text = listing.Text + index + " Booked By : " + SortList[index].passangerFName + " " + SortList[index].passangerLName + "\n";
                }
            }
            else
            {
                listing.Text = "No bookings yet";
            }

            /*
                if (travellers != null)
                {
                    for (int index = 0; index < travellers.Count; index++)
                    {
                        listing.Text = listing.Text + index + " Booked By : " + travellers[index].personFirstName + " " + travellers[index].personLastName + "\n";
                    }
                }
                else
                {
                    listing.Text = "No bookings yet";
                }
             
             */
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            initalizeSeats(true);
            IsALLSelected = true;
            label.Content = "Sorry, All seats are full !!!";
            label.Background = (Brush)new BrushConverter().ConvertFromString("#FF856B");
        }

        private void fNameTextField_LostFocus(object sender, RoutedEventArgs e)
        {
            var regexItem = new Regex("^[a-zA-Z][a-zA-Z][a-zA-Z]+$");

            if (!regexItem.IsMatch(fNameTextField.Text))
            {
                IsDetailsValids = false;
                textBoxError.Visibility = Visibility.Visible;
                textBoxError.Content = "First name cannot be null, cannot contain spaces,\nspecial characters or numbers\n and it should be 3 characters long ";
            }
            else
            {
                IsDetailsValids = true;
                textBoxError.Visibility = Visibility.Collapsed;
            }
        }

        private void lNameTextField_LostFocus(object sender, RoutedEventArgs e)
        {
            var regexItem = new Regex("^[a-zA-Z][a-zA-Z][a-zA-Z]+$");

            if (!regexItem.IsMatch(lNameTextField.Text))
            {
                IsDetailsValids = false;
                textBoxError.Visibility = Visibility.Visible;
                textBoxError.Content = "Last name cannot be null, cannot contain spaces,\nspecial characters or numbers\n and it should be 3 characters long ";
            }
            else
            {
                IsDetailsValids = true;
                textBoxError.Visibility = Visibility.Collapsed;
            }
        }

        private void phoneTextField_LostFocus(object sender, RoutedEventArgs e)
        {



            if (phoneTextField.Text.Length == 10 && !phoneTextField.Text.Any(x => char.IsLetter(x)) && !phoneTextField.Text.Any(x => char.IsSymbol(x)))
            {
                IsDetailsValids = true;
                textBoxError.Visibility = Visibility.Collapsed;
            }
            else
            {
                IsDetailsValids = false;
                textBoxError.Visibility = Visibility.Visible;
                textBoxError.Content = "Invalid Phone Number !!";
            }


        }

        private void seatSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

