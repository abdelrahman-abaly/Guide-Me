using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }



        private void UserControl2_Load(object sender, EventArgs e)
        {

        }
        private string ProcessUserInput(string userInput)
        {
            // TODO: Implement your bot's logic to process the user input
            // For now, let's assume the bot responds with a simple message
            string cleanedInput = userInput.ToLower();

            if (cleanedInput.Contains("find") || cleanedInput.Contains("offer"))
            {
                return "Welcome to our application! Here, you can explore various attractions and information about Luxor. Whether you're interested in temples, museums, or other points of interest, I can guide you to the right places. Just let me know what you're looking for!";
            }
            else if (cleanedInput.Contains("history"))
            {
                return "Welcome to our application! Here, you can explore various attractions and information about Luxor, including its rich history. We have details about temples, museums, and other points of interest that can provide insights into Luxor's fascinating past. Just let me know what specific information you're looking for!";
            }
            else if (cleanedInput.Contains("navigate") || cleanedInput.Contains("help"))
            {
                return "Welcome to our application! I'd be happy to help you navigate through the different sections and features. If you're looking for specific information about temples, museums, or other attractions in Luxor, feel free to ask, and I'll guide you to the right places!";
            }
            else if (cleanedInput.Contains("explore") || cleanedInput.Contains("discover"))
            {
                return "Welcome to our application! Here, you can explore and discover the wonders of Luxor. From ancient temples to fascinating museums, we have a wealth of information to share. Let me know what interests you, and I'll guide you through the journey!";
            }
            else if (cleanedInput.Contains("tourist attractions") || cleanedInput.Contains("sightseeing"))
            {
                return "Welcome to our application! We have a comprehensive list of tourist attractions and sightseeing spots in Luxor. Whether you're interested in visiting iconic temples or learning about the city's history, I can help you find the right places to visit.";
            }
            else if (cleanedInput.Contains("get started") || cleanedInput.Contains("begin"))
            {
                return "Welcome to our application! If you're ready to get started exploring Luxor, I'm here to assist you. Just let me know what you're interested in, and I'll provide you with the necessary information and guidance.";
            }
            else if (cleanedInput.Contains("plan my trip") || cleanedInput.Contains("itinerary"))
            {
                return "Welcome to our application! Planning a trip to Luxor? I can help you create an exciting itinerary based on your interests. Whether you're looking for cultural experiences, historical sites, or hidden gems, I'll provide you with recommendations to make your trip memorable.";
            }
            else if (cleanedInput.Contains("information") || cleanedInput.Contains("details"))
            {
                return "Welcome to our application! We have a vast collection of information and details about Luxor's attractions. From temple histories to museum exhibits, I can assist you in finding the specific information you're seeking.";
            }
            else if (cleanedInput.Contains("local tips") || cleanedInput.Contains("recommendations"))
            {
                return "Welcome to our application! If you're looking for local tips and recommendations in Luxor, you've come to the right place. Whether it's the best time to visit a temple or the most authentic local cuisine, I'll provide you with insider knowledge to enhance your experience.";
            }
            else if (cleanedInput.Contains("interactive map") || cleanedInput.Contains("navigate the city"))
            {
                return "Welcome to our application! We offer an interactive map feature that allows you to easily navigate Luxor. You can explore different attractions, find directions, and get a sense of the city's layout. Let me know if you need assistance with the map or any specific locations!";
            }
            else if (cleanedInput.Contains("hidden gems") || cleanedInput.Contains("off the beaten path"))
            {
                return "Welcome to our application! If you're looking for hidden gems and off-the-beaten-path attractions in Luxor, I can help you uncover these unique experiences. From lesser-known temples to local markets, I'll guide you to discover the city's hidden treasures.";
            }
            else if (cleanedInput.Contains("virtual tour") || cleanedInput.Contains("online experience"))
            {
                return "Welcome to our application! We offer virtual tours and online experiences that allow you to explore Luxor from the comfort of your own home. Whether you want to visit a temple or learn about ancient artifacts, I can provide you with virtual tour options.";
            }
            else if (cleanedInput.Contains("intro") || cleanedInput.Contains("introduction"))
            {
                return "Welcome to our application! How can I assist you today? If you have any questions about Luxor, temples, museums, or other attractions, feel free to ask!";
            }
            else if (cleanedInput.Contains("explore") || cleanedInput.Contains("discover"))
            {
                return "Welcome to our application! Here, you can explore and discover the wonders of Luxor. From ancient temples to fascinating museums, we have a wealth of information to share. Let me know what interests you, and I'll guide you through the journey!";
            }
            else if (cleanedInput.Contains("tourist attractions") || cleanedInput.Contains("sightseeing"))
            {
                return "Welcome to our application! We have a comprehensive list of tourist attractions and sightseeing spots in Luxor. Whether you're interested in visiting iconic temples or learning about the city's history, I can help you find the right places to visit.";
            }
            else if (cleanedInput.Contains("get started") || cleanedInput.Contains("begin"))
            {
                return "Welcome to our application! If you're ready to get started exploring Luxor, I'm here to assist you. Just let me know what you're interested in, and I'll provide you with the necessary information and guidance.";
            }
            // Add more conditions to handle common typos or misspellings
            else if (cleanedInput.Contains("explor") || cleanedInput.Contains("discovr"))
            {
                return "Welcome to our application! Here, you can explore and discover the wonders of Luxor. From ancient temples to fascinating museums, we have a wealth of information to share. Let me know what interests you, and I'll guide you through the journey!";
            }
            else if (cleanedInput.Contains("tourist attractons") || cleanedInput.Contains("sightseein"))
            {
                return "Welcome to our application! We have a comprehensive list of tourist attractions and sightseeing spots in Luxor. Whether you're interested in visiting iconic temples or learning about the city's history, I can help you find the right places to visit.";
            }
            else if (cleanedInput.Contains("get strted") || cleanedInput.Contains("bgin"))
            {
                return "Welcome to our application! If you're ready to get started exploring Luxor, I'm here to assist you. Just let me know what you're interested in, and I'll provide you with the necessary information and guidance.";
            }
            else if (cleanedInput.Contains("tell me about") || cleanedInput.Contains("give me information about"))
            {
                return "Welcome to our application! Here, you can find detailed information about Luxor, including its temples, museums, and other attractions. Feel free to ask me specific questions, and I'll provide you with the information you need.";
            }
            else if (cleanedInput.Contains("what can I find") || cleanedInput.Contains("what's available"))
            {
                return "Welcome to our application! We have a wealth of information about Luxor. From the famous temples like Karnak and Luxor Temple to the stunning Valley of the Kings and the informative Luxor Museum, you can find details about all these attractions and more.";
            }
            else if (cleanedInput.Contains("how does it work") || cleanedInput.Contains("how to navigate"))
            {
                return "Welcome to our application! It's easy to navigate and find information. You can explore different sections for temples, museums, and other attractions. If you have a specific question or need assistance, just ask, and I'll be happy to help.";
            }
            // Add more conditions to handle different phrasings or alternative questions
            else if (cleanedInput.Contains("tell me about Luxor") || cleanedInput.Contains("give me an overview"))
            {
                return "Welcome to our application! Luxor is a fascinating city in Egypt known for its rich history and ancient ruins. It was once the capital of ancient Egypt and served as a significant religious and political center. Today, Luxor is a popular tourist destination, offering visitors a chance to explore magnificent temples, discover archaeological treasures, and immerse themselves in the captivating history of this extraordinary city.";
            }
            else if (cleanedInput.Contains("what is there to see") || cleanedInput.Contains("what are the main attractions"))
            {
                return "Welcome to our application! Luxor is home to several remarkable attractions. Some of the main attractions include Karnak Temple, Luxor Temple, Hatshepsut Temple, Valley of the Kings, Luxor Museum, and the Mummification Museum. Each of these attractions offers a unique and awe-inspiring experience. Let me know if you'd like more information about any specific attraction.";
            }
            else if (cleanedInput.Contains("how can I navigate the app") || cleanedInput.Contains("how to use the application"))
            {
                return "Welcome to our application! Navigating the app is straightforward. You can use the menu or search function to find information about temples, museums, or other attractions. If you're looking for specific details or have any questions, simply ask, and I'll provide the information you need.";
            }
            // Add more conditions to handle different phrasings or alternative questions
            else if (cleanedInput.Contains("karnak temple"))
            {
                return "Karnak Temple is one of the most famous ancient Egyptian temples located in Luxor. It is a vast complex dedicated to the worship of the god Amun. The temple complex includes several temples, chapels, and other structures. It is known for its impressive Hypostyle Hall, which features massive columns. Visitors can explore the temple's fascinating history and architectural marvels.";
            }
            else if (cleanedInput.Contains("luxor temple"))
            {
                return "Luxor Temple is a large ancient Egyptian temple complex located on the east bank of the Nile River. It was built primarily during the New Kingdom period and dedicated to the god Amun. Luxor Temple is known for its stunning architecture and beautifully preserved statues and obelisks. Visitors can admire the Avenue of Sphinxes leading to the temple and explore its various halls and sanctuaries.";
            }
            else if (cleanedInput.Contains("hatshepsut temple"))
            {
                return "Hatshepsut Temple, also known as Deir el-Bahari, is an impressive mortuary temple situated on the west bank of the Nile near Luxor. It was built for Queen Hatshepsut, one of the few female pharaohs of ancient Egypt. The temple is renowned for its unique architectural design and its location against the backdrop of towering cliffs. Visitors can learn about Hatshepsut's reign and admire the temple's beautiful reliefs and statues.";
            }
            else if (cleanedInput.Contains("valley of the kings"))
            {
                return "The Valley of the Kings is a famous archaeological site in Luxor, known for its royal tombs. It served as the burial place for pharaohs and powerful nobles during the New Kingdom period. The valley is home to numerous tombs, including that of Tutankhamun. Visitors can explore some of the open tombs and marvel at the intricate wall paintings and hieroglyphs that adorn the chambers.";
            }
            else if (cleanedInput.Contains("luxor museum"))
            {
                return "Luxor Museum is a must-visit attraction for history and archaeology enthusiasts. It showcases a remarkable collection of artifacts and antiquities from ancient Egypt's various periods. The museum exhibits statues, reliefs, jewelry, and other objects that provide insights into the fascinating history and culture of Luxor and its surroundings.";
            }
            else if (cleanedInput.Contains("mummification museum"))
            {
                return "The Mummification Museum in Luxor offers a unique glimpse into the ancient Egyptian practice of mummification. The museum displays a range of artifacts related to mummification, including tools, canopic jars, and mummified animals. Visitors can learn about the complex mummification process and its significance in ancient Egyptian beliefs about the afterlife.";
            }
            // Add more conditions to handle specific information requests for other attractions or topics
            else if (cleanedInput.Contains("help"))
            {
                return "Of course! How can I assist you? If you have any questions or need information about Luxor, temples, museums, or any other topic, feel free to ask!";
            }
            else if (cleanedInput.Contains("guide"))
            {
                return "Absolutely! I'm here to guide you. Let me know what you're looking for, and I'll help you navigate the application and find the information you need.";
            }
            // Add more conditions to handle different assistance requests
            //temples info 
            else if (cleanedInput.Contains("temple"))
            {
                if (cleanedInput.Contains("karnak"))
                {
                    return "Karnak Temple is a vast temple complex dedicated to the ancient Egyptian gods. It is one of the largest religious buildings ever constructed, featuring impressive columns, obelisks, and statues. It is a must-visit site in Luxor.";
                }
                else if (cleanedInput.Contains("luxor"))
                {
                    return "Luxor Temple, also known as the Temple of Amun, is a stunning ancient Egyptian temple located in the heart of Luxor. It was dedicated to the Theban Triad of Amun, Mut, and Khonsu. The temple is famous for its magnificent statues and well-preserved hieroglyphs.";
                }
                else if (cleanedInput.Contains("hatshepsut"))
                {
                    return "Hatshepsut Temple, also known as Deir el-Bahari, is an impressive mortuary temple dedicated to the pharaoh Hatshepsut. It is renowned for its unique architectural design and beautiful reliefs. The temple offers breathtaking views of the surrounding cliffs and the Valley of the Kings.";
                }
                else if (cleanedInput.Contains("valley") && cleanedInput.Contains("kings"))
                {
                    return "The Valley of the Kings is a famous archaeological site in Luxor where many ancient pharaohs were buried. It is home to magnificent tombs, including the tomb of Tutankhamun. Exploring the valley provides a glimpse into the grandeur and mysteries of ancient Egyptian burial practices.";
                }
                else if (cleanedInput.Contains("museum"))
                {
                    if (cleanedInput.Contains("luxor"))
                    {
                        return "The Luxor Museum is a fascinating museum showcasing a collection of ancient Egyptian artifacts, including statues, jewelry, and royal mummies. It offers valuable insights into the history and culture of ancient Egypt.";
                    }
                    else if (cleanedInput.Contains("mummification"))
                    {
                        return "The Mummification Museum is a unique museum dedicated to the ancient Egyptian art of mummification. It provides a detailed overview of the mummification process and displays various mummies and related artifacts.";
                    }
                }
                else
                {
                    return "I'm sorry, I don't have information about that specific temple. Could you please provide more details or ask about another temple?";
                }
            }
            else if (cleanedInput.Contains("click") || cleanedInput.Contains("information"))
            {
                return "To get more detailed information about a specific temple, you can click on the respective temple name or image. This will take you to a dedicated page with comprehensive information, history, and photos of the temple.";
            }
            //valley kings
            else if (cleanedInput.Contains("valley") && cleanedInput.Contains("kings"))
            {
                if (cleanedInput.Contains("history"))
                {
                    return "The Valley of the Kings, located on the west bank of the Nile River, served as the burial ground for numerous pharaohs of the New Kingdom period. It was used for royal burials from approximately the 16th to the 11th century BC. The valley is renowned for its rich archaeological discoveries and the well-preserved tombs of pharaohs and high-ranking officials.";
                }
                else if (cleanedInput.Contains("tutankhamun") || cleanedInput.Contains("king tut"))
                {
                    return "The most famous tomb in the Valley of the Kings is that of King Tutankhamun, also known as King Tut. Discovered by Howard Carter in 1922, the tomb contained a wealth of treasures and artifacts. King Tutankhamun's tomb is a major attraction, and visitors can explore the burial chamber and view the iconic golden funerary mask.";
                }
                else if (cleanedInput.Contains("visiting") || cleanedInput.Contains("tickets"))
                {
                    return "To visit the Valley of the Kings, you can purchase tickets at the site entrance. The ticket grants access to a specific number of tombs, and additional tickets are required for special tombs. It's advisable to plan your visit in advance and check the visiting hours and ticket availability.";
                }
                else if (cleanedInput.Contains("explore") || cleanedInput.Contains("tour"))
                {
                    return "Exploring the Valley of the Kings is an incredible journey into ancient Egyptian history. Visitors can enter the tombs, admire the intricate wall paintings and hieroglyphs, and witness the grandeur of the pharaohs' final resting places. It's recommended to join a guided tour or hire a knowledgeable guide to enhance your experience and learn more about the site.";
                }
                else
                {
                    return "The Valley of the Kings is an iconic archaeological site in Luxor, Egypt. It served as the burial ground for pharaohs and high-ranking officials of the New Kingdom. If you have specific questions or need more information about the history, visiting procedures, or famous tombs in the Valley of the Kings, feel free to ask!";
                }
            }
            //musemums
            if (cleanedInput.Contains("luxor museum"))
            {
                if (cleanedInput.Contains("location"))
                {
                    return "The Luxor Museum is located on the east bank of the Nile River in Luxor, Egypt. It is situated near the Luxor Temple and is easily accessible for visitors.";
                }
                else if (cleanedInput.Contains("collections") || cleanedInput.Contains("exhibits"))
                {
                    return "The Luxor Museum houses a diverse collection of artifacts from ancient Egypt's pharaonic period. It showcases statues, stelae, jewelry, pottery, and other fascinating objects that provide insights into the rich history and culture of ancient Egypt.";
                }
                else if (cleanedInput.Contains("hours") || cleanedInput.Contains("visiting"))
                {
                    return "The Luxor Museum is open daily from 9:00 AM to 5:00 PM. It is recommended to check the museum's official website or contact them directly for any updates or changes in visiting hours.";
                }
                else
                {
                    return "The Luxor Museum is a must-visit for anyone interested in ancient Egyptian history. It showcases a remarkable collection of artifacts from the pharaonic period. If you have any specific questions or need more information about the museum's location, collections, or visiting hours, feel free to ask!";
                }
            }
            else if (cleanedInput.Contains("mummification museum"))
            {
                if (cleanedInput.Contains("location"))
                {
                    return "The Mummification Museum is located on the west bank of the Nile River in Luxor, Egypt. It is situated near the Valley of the Kings and is easily accessible for visitors.";
                }
                else if (cleanedInput.Contains("exhibits") || cleanedInput.Contains("process"))
                {
                    return "The Mummification Museum provides insights into the ancient Egyptian art of mummification. It displays various artifacts related to the mummification process, including tools, mummified animals, and even a few human mummies. Visitors can learn about the rituals and techniques used by ancient Egyptians in preserving the deceased.";
                }
                else if (cleanedInput.Contains("hours") || cleanedInput.Contains("visiting"))
                {
                    return "The Mummification Museum is open daily from 9:00 AM to 5:00 PM. It is advisable to check the museum's official website or contact them directly for any updates or changes in visiting hours.";
                }
                else
                {
                    return "The Mummification Museum offers a fascinating journey into the ancient Egyptian practice of mummification. If you have any specific questions or need more information about the museum's location, exhibits, or visiting hours, feel free to ask!";
                }
            }
            // guided tour through temples
            if (cleanedInput.Contains("guided tour"))
            {
                if (cleanedInput.Contains("temples"))
                {
                    return "The guided tour of the temples in Luxor offers an immersive experience where you can explore the ancient wonders of Karnak Temple, Luxor Temple, Hatshepsut Temple, and other significant sites. Knowledgeable guides will provide historical and cultural insights throughout the tour. You can find more information and book the guided tour by clicking on the 'Temples' button in the application.";
                }
                else if (cleanedInput.Contains("valley of the kings"))
                {
                    return "The guided tour of the Valley of the Kings is an extraordinary opportunity to discover the tombs of ancient Egyptian pharaohs. You will explore the intricately decorated chambers and learn about the fascinating history behind these royal resting places. To join the guided tour of the Valley of the Kings, click on the 'Temples' button in the application.";
                }
                else if (cleanedInput.Contains("museums"))
                {
                    return "The guided tour of the museums in Luxor allows you to delve into the captivating world of ancient Egyptian artifacts and history. You can visit the Luxor Museum, which showcases a remarkable collection, or explore the Mummification Museum to learn about the intricate mummification process. To join the guided tour of the museums, click on the 'Temples' button in the application.";
                }
                else
                {
                    return "The guided tour offers a comprehensive exploration of the rich historical and cultural heritage of Luxor. Whether you're interested in temples, the Valley of the Kings, museums, or other notable sites, the guided tour provides an immersive experience. To find more information and book the guided tour, click on the 'Temples' button in the application.";
                }
            }
            // intro to restaurants 
            if (cleanedInput.Contains("restaurants"))
            {
                return "The Restaurants section in our application is your guide to exploring the diverse culinary scene in Luxor. Here, you'll discover a collection of famous restaurants that offer a wide range of cuisines to satisfy your taste buds. From Italian delicacies to seafood specialties and traditional Oriental dishes, Luxor has something for everyone.";

            }
            else if (cleanedInput.Contains("restaurants") && cleanedInput.Contains("button"))
            {
                return "To explore the restaurants in more detail, simply click on the 'Restaurants' button. It will take you to a dedicated page where you can find comprehensive information about each restaurant, including their menus, location, ambiance, and customer reviews. Whether you're seeking a romantic dinner spot, a family-friendly restaurant, or a place to savor local flavors, our Restaurants section has got you covered.";
            }
            //all restaurants
            if (cleanedInput.Contains("restaurants"))
            {
                if (cleanedInput.Contains("cook door"))
                {
                    return "Cook Door is a renowned restaurant in Luxor that specializes in Italian cuisine. It is known for serving some of the best Italian food in town, offering a unique dining experience. From traditional pasta dishes to wood-fired pizzas, Cook Door is sure to delight your taste buds. Don't miss the opportunity to try their signature dishes and experience the authentic flavors of Italy.";
                }
                else if (cleanedInput.Contains("kfc"))
                {
                    return "KFC is a famous restaurant known for its quality and delicious meals. It offers a peaceful and enjoyable dining experience, perfect for enjoying a meal in a calm environment.";
                }
                else if (cleanedInput.Contains("mac"))
                {
                    return "Mac is a renowned restaurant located in front of Luxor Temple. It offers a unique dining experience with a beautiful view. Known as one of the most famous restaurants in the world, Mac guarantees high-quality food and a memorable dining experience.";
                }
                else if (cleanedInput.Contains("shark wheels fresh"))
                {
                    return "Shark Wheels Fresh is a popular seafood restaurant in Luxor. It is highly rated by tourists and offers a unique and delightful experience. If you're a fan of seafood, this restaurant is a must-visit.";
                }
                else if (cleanedInput.Contains("om hashem"))
                {
                    return "Om Hashem is a fantastic place to try authentic local dishes. It offers a unique and enjoyable experience for those who want to explore Oriental cuisine.";
                }
                else if (cleanedInput.Contains("pizza rome"))
                {
                    return "Pizza Rome is a renowned restaurant known for its delicious pizza. If you're craving a special and quiet experience with great pizza, this is the place to go.";
                }
                // Check for specific questions about restaurants
                if (cleanedInput.Contains("food does cook door offer"))
                {
                    return "Cook Door is famous for making the best Italian food, offering a different experience in food.";
                }
                else if (cleanedInput.Contains("makes kfc special"))
                {
                    return "KFC is renowned for its quality food and provides a quiet and enjoyable environment for your meal.";
                }
                else if (cleanedInput.Contains("why should i visit mac"))
                {
                    return "Mac offers a unique experience with a beautiful view in front of Luxor Temple. It is one of the most famous restaurants globally, ensuring high-quality food.";
                }
                else if (cleanedInput.Contains("makes shark wheels fresh stand out"))
                {
                    return "Shark Wheels Fresh is one of the most famous seafood restaurants in Luxor, known for its delicious dishes and high ratings from tourists.";
                }
                else if (cleanedInput.Contains("what can i expect at om hashem"))
                {
                    return "OM Hashem offers a unique experience with famous dishes in the country and a delightful taste of oriental food.";
                }
                else if (cleanedInput.Contains("why should i try pizza rome"))
                {
                    return "Pizza Rome is one of the most famous restaurants known for its mouthwatering pizzas, providing a special and peaceful dining experience.";
                }
                // Default response if the user's input doesn't match any specific restaurant
                return "I'm sorry, I don't have information about that restaurant. Please let me know if there's anything else I can assist you with.";
            }
            //hotels intro
            if (cleanedInput.Contains("hotels") || cleanedInput.Contains("accommodation"))
            {
                return "In Luxor, there are various hotels available to cater to different preferences and budgets. Whether you are looking for a small family-run hotel or a large international chain, you will find a wide range of options. Most hotels offer services such as room service, laundry, and concierge to enhance your stay. Let me know if you have any specific questions about any hotels.";
            }
            if (cleanedInput.Contains("etabe"))
            {
                return "Etabe is a hotel in Luxor offering comfortable accommodations. The pricing for a night's stay ranges from $30 to $40. It is part of the range of hotels that can be found in Luxor, from small family-run businesses to large international chains. Most hotels in Luxor provide a variety of services, such as room service, laundry, and concierge.";
            }
            else if (cleanedInput.Contains("hilton"))
            {
                return "Hilton is a well-known hotel brand with a presence in Luxor. The pricing for a night's stay at Hilton ranges from $30 to $40. Like other hotels in Luxor, Hilton offers a range of services to enhance your stay, including room service, laundry, and concierge.";
            }
            else if (cleanedInput.Contains("ibrotel"))
            {
                return "Ibrotel is a hotel in Luxor offering comfortable accommodations. The pricing for a night's stay at Ibrotel ranges from $30 to $40. It is part of the range of hotels available in Luxor, from small family-run businesses to large international chains. Most hotels in Luxor provide a variety of services, such as room service, laundry, and concierge.";
            }
            else if (cleanedInput.Contains("isis"))
            {
                return "ISIS is a hotel in Luxor offering comfortable accommodations. The pricing for a night's stay at ISIS ranges from $30 to $40. It is part of the range of hotels that can be found in Luxor, from small family-run businesses to large international chains. Most hotels in Luxor provide a variety of services, such as room service, laundry, and concierge.";
            }
            else if (cleanedInput.Contains("joli valle"))
            {
                return "Joli Valle is a hotel in Luxor offering comfortable accommodations. The pricing for a night's stay at Joli Valle ranges from $30 to $40. It is part of the range of hotels available in Luxor, from small family-run businesses to large international chains. Most hotels in Luxor provide a variety of services, such as room service, laundry, and concierge.";
            }
            else if (cleanedInput.Contains("  hotel"))
            {
                // If the user's input does not match any specific hotel, provide a generic response
                return "I'm sorry, I don't have information about that specific hotel. Please let me know if you have any other inquiries.";
            }
            // cafe intro
            if (cleanedInput.Contains("cafes"))
            {
                if (cleanedInput.Contains(""))
                {
                    return "Luxor is home to several famous cafes where you can enjoy a delightful culinary experience. These cafes are known for their cozy ambiance and a wide selection of beverages and snacks. Whether you're looking for a refreshing cup of coffee or a quick bite to eat, Luxor's cafes offer something for everyone. Explore the cafes below to find your perfect spot to relax and indulge.";
                }
                if (cleanedInput.Contains("al-sahaby"))
                {
                    return "Al-sahaby is a small eating and drinking establishment, historically a coffeehouse, usually featuring a limited menu. It is known for its cozy atmosphere and traditional Egyptian coffee. It's a perfect place to relax and enjoy a cup of coffee while immersing yourself in the local culture.";
                }
                else if (cleanedInput.Contains("badiea"))
                {
                    return "Badiea is a small eating and drinking establishment, historically a coffeehouse, usually featuring a limited menu. It offers a cozy and inviting atmosphere, where you can enjoy a variety of hot and cold beverages along with delicious snacks. It's a popular spot among locals and tourists alike.";
                }
                else if (cleanedInput.Contains("relax"))
                {
                    return "Relax is a small eating and drinking establishment, historically a coffeehouse, usually featuring a limited menu. It prides itself on creating a peaceful and serene environment for its customers. You can unwind with a cup of coffee or tea and savor some delectable treats. It's an ideal place to escape the hustle and bustle of the city.";
                }
                else if (cleanedInput.Contains("sky roof"))
                {
                    return "Sky Roof is a small eating and drinking establishment, historically a coffeehouse, usually featuring a limited menu. It offers a unique experience with its rooftop seating arrangement, providing stunning views of the city. You can enjoy a wide range of beverages and snacks while taking in the panoramic vistas. It's a must-visit spot for those seeking a memorable cafe experience.";
                }
            }
            //hospitals and pharmacies intro
            if (cleanedInput.Contains("hospitals") || cleanedInput.Contains("pharmacies"))
            {
                if (cleanedInput.Contains(""))
                    return "Luxor is home to several renowned hospitals and pharmacies. Whether you need medical assistance or pharmaceutical services, Luxor has you covered. Please click the 'Hospitals' button to view the pictures of Luxor hospitals.";

                else if (cleanedInput.Contains(""))
                {
                    return "In Luxor, you can find various pharmacies offering a range of medications and healthcare products. Please click the 'Pharmacies' button to explore the pictures of Luxor pharmacies.";
                }
                else if (cleanedInput.Contains("luxor international hospital"))
                {
                    return "Luxor International Hospital is a leading healthcare facility in Luxor, known for its state-of-the-art medical services and experienced staff.";
                }
                else if (cleanedInput.Contains("horus hospital"))
                {
                    return "Horus Hospital is a renowned hospital in Luxor, offering a wide range of medical specialties and comprehensive healthcare services.";
                }
                else if (cleanedInput.Contains("isis specialized hospital"))
                {
                    return "ISIS Specialized Hospital is a specialized medical center in Luxor, focusing on specific areas of expertise and providing advanced medical treatments.";
                }

                // Details for Pharmacies
                else if (cleanedInput.Contains("19955 delmar and atalla pharmacy"))
                {
                    return "19955 Delmar and Atalla Pharmacy is a well-known pharmacy in Luxor, offering a wide range of medications and pharmaceutical products.";
                }
                else if (cleanedInput.Contains("19011 pharmacies"))
                {
                    return "19011 Pharmacies is a trusted name in Luxor, providing a variety of pharmaceutical services and high-quality medications.";
                }
                else if (cleanedInput.Contains("elezaby pharmacies"))
                {
                    return "Elezaby Pharmacies is a chain of pharmacies in Luxor, known for its reliable services, friendly staff, and diverse range of healthcare products.";
                }
                else
                {
                    return "I'm sorry, I don't have information about that specific hospital. Please let me know if you have any other inquiries.";
                }
            }
            //ready program intro
            if (cleanedInput.Contains("ready to go programs"))
            {
                if (cleanedInput.Contains("yes"))
                {
                    return "Are you looking for a hassle-free way to plan your day in Luxor? Our 'Ready to Go Programs' feature is here to help! With just a few clicks, you can create a personalized itinerary based on your preferences. Simply select the attractions you wish to visit, and our app will generate a customized program for your day, ensuring you make the most of your time in Luxor. Let's dive into the details!";
                }
                else if (cleanedInput.Contains("temple"))
                {
                    return "If you're interested in exploring the ancient temples of Luxor, our program will guide you through the must-visit temples such as Karnak Temple, Luxor Temple, and Hatshepsut Temple. You'll have the opportunity to immerse yourself in the rich history and awe-inspiring architecture of these iconic landmarks.";
                }
                else if (cleanedInput.Contains("cafe"))
                {
                    return "For coffee lovers, our program will include a visit to popular cafes in Luxor such as Al-sahaby, Badiea, and Relax. You can relax and enjoy a cup of coffee while experiencing the cozy atmosphere and local vibes of these cafes.";
                }
                else if (cleanedInput.Contains("hotel"))
                {
                    return "To ensure a comfortable stay, our program will suggest top-rated hotels in Luxor such as Etabe, Hilton, and Ibrotel. These hotels offer a range of amenities and services to make your stay enjoyable and relaxing.";
                }
                else if (cleanedInput.Contains("attraction"))
                {
                    return "In addition to temples, cafes, and hotels, our program can include other attractions in Luxor such as the Valley of the Kings, Luxor Museum, and Mummification Museum. You'll have the opportunity to explore the diverse cultural and historical highlights of the city.";
                }
                else
                {
                    return "Our 'Ready to Go Programs' feature allows you to create a personalized itinerary by selecting the attractions you want to visit. Whether you're interested in temples, cafes, hotels, or other attractions, our program will tailor a day-long plan to make the most of your time in Luxor.";
                }
            }
            if (cleanedInput.Contains("support") || cleanedInput.Contains("customer support"))
            {
                return "Please go to support section and scan the QR code to contact with our support team";
            }
            else
            {
                return "please provide more information that i can help you with";
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            string userInput = textBox2.Text;

            // Process user input
            string botResponse = ProcessUserInput(userInput);

            // Display conversation in the ConversationHistoryTextBox
            DisplayConversation(userInput, botResponse);
            textBox2.Clear();
            textBox2.Focus();

        }
        private void DisplayConversation(string userMessage, string botMessage)
        {
            textBox1.AppendText("User: " + userMessage + Environment.NewLine);
            textBox1.AppendText("Bot: " + botMessage + Environment.NewLine);
        }
    }
}
