﻿using System;
using System.Collections.ObjectModel;

namespace TestCollectionView.ViewModels
{
    public class Animal
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        public string ImageUrl { get; set; }
    }

    public class AnimalGroup : ObservableCollection<Animal>
    {
        public string Name { get; private set; }

        public AnimalGroup(string name, List<Animal> animals) : base(animals)
        {
            Name = name;
        }
    }

    public class GroupedCollectionViewModel
    {
        public GroupedCollectionViewModel()
        {
            Init();

        }

        private void Init()
        {
            AnimalBaseList.Clear();
            AnimalBaseList.Add(new AnimalGroup("Bears", new List<Animal>
            {
                new Animal
                {
                    Name = "American Black Bear",
                    Location = "North America",
                    Details = "The American black bear is a medium-sized bear native to North America. It is the continent's smallest and most widely distributed bear species. American black bears are omnivores, with their diets varying greatly depending on season and location. They typically live in largely forested areas, but do leave forests in search of food. Sometimes they become attracted to human communities because of the immediate availability of food. The American black bear is the world's most common bear species.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/0/08/01_Schwarzbär.jpg"
                },
                new Animal
                {
                    Name = "Asian Black Bear",
                    Location = "Asia",
                    Details = "The Asian black bear, also known as the moon bear and the white-chested bear, is a medium-sized bear species native to Asia and largely adapted to arboreal life. It lives in the Himalayas, in the northern parts of the Indian subcontinent, Korea, northeastern China, the Russian Far East, the Honshū and Shikoku islands of Japan, and Taiwan. It is classified as vulnerable by the International Union for Conservation of Nature (IUCN), mostly because of deforestation and hunting for its body parts.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Ursus_thibetanus_3_%28Wroclaw_zoo%29.JPG/180px-Ursus_thibetanus_3_%28Wroclaw_zoo%29.JPG"
                },
                new Animal
                {
                    Name = "Brown Bear",
                    Location = "Northern Eurasia & North America",
                    Details = "The brown bear is a bear that is found across much of northern Eurasia and North America. In North America the population of brown bears are often called grizzly bears. It is one of the largest living terrestrial members of the order Carnivora, rivaled in size only by its closest relative, the polar bear, which is much less variable in size and slightly larger on average. The brown bear's principal range includes parts of Russia, Central Asia, China, Canada, the United States, Scandinavia and the Carpathian region, especially Romania, Anatolia and the Caucasus. The brown bear is recognized as a national and state animal in several European countries.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5d/Kamchatka_Brown_Bear_near_Dvuhyurtochnoe_on_2015-07-23.jpg/320px-Kamchatka_Brown_Bear_near_Dvuhyurtochnoe_on_2015-07-23.jpg"
                },
                new Animal
                {
                    Name = "Grizzly-Polar Bear Hybrid",
                    Location = "Canadian Artic",
                    Details = "A grizzly–polar bear hybrid is a rare ursid hybrid that has occurred both in captivity and in the wild. In 2006, the occurrence of this hybrid in nature was confirmed by testing the DNA of a unique-looking bear that had been shot near Sachs Harbour, Northwest Territories on Banks Island in the Canadian Arctic. The number of confirmed hybrids has since risen to eight, all of them descending from the same female polar bear.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7e/Grolar.JPG/276px-Grolar.JPG"
                },
                new Animal
                {
                    Name = "Sloth Bear",
                    Location = "Indian Subcontinent",
                    Details = "The sloth bear is an insectivorous bear species native to the Indian subcontinent. It is listed as Vulnerable on the IUCN Red List, mainly because of habitat loss and degradation. It has also been called labiated bear because of its long lower lip and palate used for sucking insects. Compared to brown and black bears, the sloth bear is lankier, has a long, shaggy fur and a mane around the face, and long, sickle-shaped claws. It evolved from the ancestral brown bear during the Pleistocene and through convergent evolution shares features found in insect-eating mammals.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6c/Sloth_Bear_Washington_DC.JPG/320px-Sloth_Bear_Washington_DC.JPG"
                },
                new Animal
                {
                    Name = "Sun Bear",
                    Location = "Southeast Asia",
                    Details = "The sun bear is a bear species occurring in tropical forest habitats of Southeast Asia. It is listed as Vulnerable on the IUCN Red List. The global population is thought to have declined by more than 30% over the past three bear generations. Suitable habitat has been dramatically reduced due to the large-scale deforestation that has occurred throughout Southeast Asia over the past three decades. The sun bear is also known as the honey bear, which refers to its voracious appetite for honeycombs and honey.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a6/Sitting_sun_bear.jpg/319px-Sitting_sun_bear.jpg"
                },
                new Animal
                {
                    Name = "Polar Bear",
                    Location = "Artic Circle",
                    Details = "The polar bear is a hypercarnivorous bear whose native range lies largely within the Arctic Circle, encompassing the Arctic Ocean, its surrounding seas and surrounding land masses. It is a large bear, approximately the same size as the omnivorous Kodiak bear. A boar (adult male) weighs around 350–700 kg (772–1,543 lb), while a sow (adult female) is about half that size. Although it is the sister species of the brown bear, it has evolved to occupy a narrower ecological niche, with many body characteristics adapted for cold temperatures, for moving across snow, ice and open water, and for hunting seals, which make up most of its diet. Although most polar bears are born on land, they spend most of their time on the sea ice. Their scientific name means maritime bear and derives from this fact. Polar bears hunt their preferred food of seals from the edge of sea ice, often living off fat reserves when no sea ice is present. Because of their dependence on the sea ice, polar bears are classified as marine mammals.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/6/66/Polar_Bear_-_Alaska_%28cropped%29.jpg"
                },
                new Animal
                {
                    Name = "Spectacled Bear",
                    Location = "South America",
                    Details = "The spectacled bear, also known as the Andean bear or Andean short-faced bear and locally as jukumari (Aymara), ukumari (Quechua) or ukuku, is the last remaining short-faced bear. Its closest relatives are the extinct Florida spectacled bear, and the giant short-faced bears of the Middle to Late Pleistocene age. Spectacled bears are the only surviving species of bear native to South America, and the only surviving member of the subfamily Tremarctinae. The species is classified as Vulnerable by the IUCN because of habitat loss.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/99/Spectacled_Bear_-_Houston_Zoo.jpg/264px-Spectacled_Bear_-_Houston_Zoo.jpg"
                },
                new Animal
                {
                    Name = "Short-faced Bear",
                    Location = "Extinct",
                    Details = "The short-faced bears is an extinct bear genus that inhabited North America during the Pleistocene epoch from about 1.8 Mya until 11,000 years ago. It was the most common early North American bear and was most abundant in California. There are two recognized species: Arctodus pristinus and Arctodus simus, with the latter considered to be one of the largest known terrestrial mammalian carnivores that has ever existed. It has been hypothesized that their extinction coincides with the Younger Dryas period of global cooling commencing around 10,900 BC.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b8/ArctodusSimusSkeleton.jpg/320px-ArctodusSimusSkeleton.jpg"
                },
                new Animal
                {
                    Name = "California Grizzly Bear",
                    Location = "Extinct",
                    Details = "The California grizzly bear is an extinct subspecies of the grizzly bear, the very large North American brown bear. Grizzly could have meant grizzled (that is, with golden and grey tips of the hair) or fear-inspiring. Nonetheless, after careful study, naturalist George Ord formally classified it in 1815 – not for its hair, but for its character – as Ursus horribilis (terrifying bear). Genetically, North American grizzlies are closely related; in size and coloring, the California grizzly bear was much like the grizzly bear of the southern coast of Alaska. In California, it was particularly admired for its beauty, size and strength. The grizzly became a symbol of the Bear Flag Republic, a moniker that was attached to the short-lived attempt by a group of American settlers to break away from Mexico in 1846. Later, this rebel flag became the basis for the state flag of California, and then California was known as the Bear State.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/d/de/Monarch_the_bear.jpg"
                }
            }));

            AnimalBaseList.Add(new AnimalGroup("Cats", new List<Animal>
            {
                new Animal
                {
                    Name = "Abyssinian",
                    Location = "Ethopia",
                    Details = "The Abyssinian is a breed of domestic short-haired cat with a distinctive tickedtabby coat, in which individual hairs are banded with different colors. The breed is named for Abyssinia (now called Ethiopia), where it is believed to have originated.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9b/Gustav_chocolate.jpg/168px-Gustav_chocolate.jpg"
                },
                new Animal
                {
                    Name = "Arabian Mau",
                    Location = "Arabian Peninsula",
                    Details = "The Arabian Mau is a formal breed of domestic cat, originated from the desert cat, a short-haired landrace native to the desert of the Arabian Peninsula. It lives there in the streets and has adapted very well to the extreme climate. The Arabian Mau is recognized as a formal breed by few fancier and breeder organization and cat registry, World Cat Federation (WCF) and Emirates Feline Federation (EFF). Based on one landrace, the Arabian Mau is a natural breed.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/d/d3/Bex_Arabian_Mau.jpg"
                },
                new Animal
                {
                    Name = "Bengal",
                    Location = "Asia",
                    Details = "The Bengal cat is a domesticated cat breed created from hybrids of domestic cats and the Asian leopard cat – the breed name comes from the taxonomic name. Back-crossing to domestic cats is then done with the goal of creating a healthy, and docile cat with wild-looking, high-contrast coat. Bengals have a wild appearance and may show spots, rosettes, arrowhead markings, or marbling.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/ba/Paintedcats_Red_Star_standing.jpg/187px-Paintedcats_Red_Star_standing.jpg"
                },
                new Animal
                {
                    Name = "Burmese",
                    Location = "Thailand",
                    Details = "The Burmese cat is a breed of domestic cat, originating in Thailand, believed to have its roots near the present Thai-Burma border and developed in the United States and Britain.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/0/04/Blissandlucky11.jpg"
                },
                new Animal
                {
                    Name = "Cyprus",
                    Location = "Cyprus",
                    Details = "Cyprus cats, also known as Cypriot cats, Saint Helen cats, and Saint Nicholas cats, are a landrace of domestic cat found across the island of Cyprus. A standardized breed is being developed from them; among cat fancier and breeder organizations, it is presently fully recognized by the World Cat Federation (WCF), with breeding regulated by the World Cat Congress (WCC), under the name Aphrodite's Giant; and provisionally by The International Cat Association (TICA) as the Aphrodite. All three organizations permit shorthaired and semi-longhaired versions and no out-crossing to other breeds.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b9/CyprusShorthair.jpg/320px-CyprusShorthair.jpg"
                },
                new Animal
                {
                    Name = "German Rex",
                    Location = "Germany",
                    Details = "The German Rex is a medium-sized breed with slender legs of a medium length. The head is round with well-developed cheeks and large, open ears. The eyes are of medium size in colours related to the coat colour. The coat is silky and short with a tendency to curl. The whiskers also curl, though less strongly than in the Cornish Rex. They may be nearly straight. All colours of coat, including white, are allowed. The body development is heavier than in the Cornish Rex - more like the European Shorthairs.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/c/c7/German_rex_harry_%28cropped%29.jpg"
                },
                new Animal
                {
                    Name = "Highlander",
                    Location = "United States",
                    Details = "The Highlander (also known as the Highlander Shorthair, and originally as the Highland Lynx), is an experimental breed of cat. The unique appearance of the Highlander comes from the deliberate cross between the Desert Lynx and the Jungle Curl breeds, also recently developed. The latter of these has some non-domestic ancestry from two Asian small cat species, the leopard cat and jungle cat, making the Highlander nominally a feline hybrid, though its foundation stock is mostly domestic cat.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/15/Highlander-7.jpg/293px-Highlander-7.jpg"
                },
                new Animal
                {
                    Name = "Peterbald",
                    Location = "Russia",
                    Details = "The Peterbald is a cat breed of Russian origin. It was created in St Petersburg in 1994 from an experimental breeding by Olga S. Mironova. They resemble Oriental Shorthairs with a hair-losing gene. The breed was accepted for Championship class competition in 2009.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/c/c7/Peterbald_male_Shango_by_Irina_Polunina.jpg"
                },
                new Animal
                {
                    Name = "Scottish Fold",
                    Location = "Scotland",
                    Details = "The Scottish Fold is a breed of domestic cat with a natural dominant-gene mutation that affects cartilage throughout the body, causing the ears to fold, bending forward and down towards the front of the head, which gives the cat what is often described as an owl-like appearance.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5d/Adult_Scottish_Fold.jpg/240px-Adult_Scottish_Fold.jpg"
                },
                new Animal
                {
                    Name = "Sphynx",
                    Location = "Europe",
                    Details = "The Sphynx cat is a breed of cat known for its lack of coat (fur). It was developed through selective breeding, starting in the 1960s. The skin should have the texture of chamois, as it has fine hairs, or they may be completely hairless. Whiskers may be present, either whole or broken, or may be totally absent. They also have a narrow, long head, and webbed feet. Their skin is the color that their fur would be, and all the usual cat markings (solid, point, van, tabby, tortie, etc.) may be found on the Sphynx cat's skin. Because they have no coat, they lose more body heat than coated cats. This makes them warm to the touch as well as heat-seeking.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e8/Sphinx2_July_2006.jpg/180px-Sphinx2_July_2006.jpg"
                }
            }));

            Animals.Add(new AnimalGroup(AnimalBaseList[0].Name, new List<Animal>()));

            // Add one to the first group
            AddAnimal();

            Animals.Add(new AnimalGroup(AnimalBaseList[1].Name, AnimalBaseList[1].ToList()));

        }


        public bool AddAnimal()
        {
            // Add animal from first group
            var sourceGroup = AnimalBaseList.First();
            var targetGroup = Animals.First();

            if (sourceGroup.Count == 0)
                return false;

            var animal = sourceGroup.First();
            targetGroup.Add(animal);
            sourceGroup.Remove(animal);

            return true;
        }

        public void Reset()
        {
            Animals.Clear();

            Init();

        }

        private List<AnimalGroup> AnimalBaseList { get; set; } = new List<AnimalGroup>();


        public ObservableCollection<AnimalGroup> Animals { get; private set; } = new ObservableCollection<AnimalGroup>();

    }
}

