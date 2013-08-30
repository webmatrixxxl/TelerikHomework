(function () {
    "use strict";

    var list = new WinJS.Binding.List();
    var groupedItems = list.createGrouped(
        function groupKeySelector(item) { return item.group.key; },
        function groupDataSelector(item) { return item.group; }
    );

    // TODO: Replace the data with your real data.
    // You can add data from asynchronous sources whenever it becomes available.
    generateSampleData().forEach(function (item) {
        list.push(item);
    });

    WinJS.Namespace.define("Data", {
        items: groupedItems,
        groups: groupedItems.groups,
        getItemReference: getItemReference,
        getItemsFromGroup: getItemsFromGroup,
        resolveGroupReference: resolveGroupReference,
        resolveItemReference: resolveItemReference
    });

    // Get a reference for an item, using the group key and item title as a
    // unique reference to the item that can be easily serialized.
    function getItemReference(item) {
        return [item.group.key, item.title];
    }

    // This function returns a WinJS.Binding.List containing only the items
    // that belong to the provided group.
    function getItemsFromGroup(group) {
        return list.createFiltered(function (item) { return item.group.key === group.key; });
    }

    // Get the unique group corresponding to the provided group key.
    function resolveGroupReference(key) {
        for (var i = 0; i < groupedItems.groups.length; i++) {
            if (groupedItems.groups.getAt(i).key === key) {
                return groupedItems.groups.getAt(i);
            }
        }
    }

    // Get a unique item from the provided string array, which should contain a
    // group key and an item title.
    function resolveItemReference(reference) {
        for (var i = 0; i < groupedItems.length; i++) {
            var item = groupedItems.getAt(i);
            if (item.group.key === reference[0] && item.title === reference[1]) {
                return item;
            }
        }
    }

    // Returns an array of sample data that can be added to the application's
    // data list. 
    function generateSampleData() {
        var itemContent = "<p>Curabitur class aliquam vestibulum nam curae maecenas sed integer cras phasellus suspendisse quisque donec dis praesent accumsan bibendum pellentesque condimentum adipiscing etiam consequat vivamus dictumst aliquam duis convallis scelerisque est parturient ullamcorper aliquet fusce suspendisse nunc hac eleifend amet blandit facilisi condimentum commodo scelerisque faucibus aenean ullamcorper ante mauris dignissim consectetuer nullam lorem vestibulum habitant conubia elementum pellentesque morbi facilisis arcu sollicitudin diam cubilia aptent vestibulum auctor eget dapibus pellentesque inceptos leo egestas interdum nulla consectetuer suspendisse adipiscing pellentesque proin lobortis sollicitudin augue elit mus congue fermentum parturient fringilla euismod feugiat</p><p>Curabitur class aliquam vestibulum nam curae maecenas sed integer cras phasellus suspendisse quisque donec dis praesent accumsan bibendum pellentesque condimentum adipiscing etiam consequat vivamus dictumst aliquam duis convallis scelerisque est parturient ullamcorper aliquet fusce suspendisse nunc hac eleifend amet blandit facilisi condimentum commodo scelerisque faucibus aenean ullamcorper ante mauris dignissim consectetuer nullam lorem vestibulum habitant conubia elementum pellentesque morbi facilisis arcu sollicitudin diam cubilia aptent vestibulum auctor eget dapibus pellentesque inceptos leo egestas interdum nulla consectetuer suspendisse adipiscing pellentesque proin lobortis sollicitudin augue elit mus congue fermentum parturient fringilla euismod feugiat</p><p>Curabitur class aliquam vestibulum nam curae maecenas sed integer cras phasellus suspendisse quisque donec dis praesent accumsan bibendum pellentesque condimentum adipiscing etiam consequat vivamus dictumst aliquam duis convallis scelerisque est parturient ullamcorper aliquet fusce suspendisse nunc hac eleifend amet blandit facilisi condimentum commodo scelerisque faucibus aenean ullamcorper ante mauris dignissim consectetuer nullam lorem vestibulum habitant conubia elementum pellentesque morbi facilisis arcu sollicitudin diam cubilia aptent vestibulum auctor eget dapibus pellentesque inceptos leo egestas interdum nulla consectetuer suspendisse adipiscing pellentesque proin lobortis sollicitudin augue elit mus congue fermentum parturient fringilla euismod feugiat</p><p>Curabitur class aliquam vestibulum nam curae maecenas sed integer cras phasellus suspendisse quisque donec dis praesent accumsan bibendum pellentesque condimentum adipiscing etiam consequat vivamus dictumst aliquam duis convallis scelerisque est parturient ullamcorper aliquet fusce suspendisse nunc hac eleifend amet blandit facilisi condimentum commodo scelerisque faucibus aenean ullamcorper ante mauris dignissim consectetuer nullam lorem vestibulum habitant conubia elementum pellentesque morbi facilisis arcu sollicitudin diam cubilia aptent vestibulum auctor eget dapibus pellentesque inceptos leo egestas interdum nulla consectetuer suspendisse adipiscing pellentesque proin lobortis sollicitudin augue elit mus congue fermentum parturient fringilla euismod feugiat</p><p>Curabitur class aliquam vestibulum nam curae maecenas sed integer cras phasellus suspendisse quisque donec dis praesent accumsan bibendum pellentesque condimentum adipiscing etiam consequat vivamus dictumst aliquam duis convallis scelerisque est parturient ullamcorper aliquet fusce suspendisse nunc hac eleifend amet blandit facilisi condimentum commodo scelerisque faucibus aenean ullamcorper ante mauris dignissim consectetuer nullam lorem vestibulum habitant conubia elementum pellentesque morbi facilisis arcu sollicitudin diam cubilia aptent vestibulum auctor eget dapibus pellentesque inceptos leo egestas interdum nulla consectetuer suspendisse adipiscing pellentesque proin lobortis sollicitudin augue elit mus congue fermentum parturient fringilla euismod feugiat</p><p>Curabitur class aliquam vestibulum nam curae maecenas sed integer cras phasellus suspendisse quisque donec dis praesent accumsan bibendum pellentesque condimentum adipiscing etiam consequat vivamus dictumst aliquam duis convallis scelerisque est parturient ullamcorper aliquet fusce suspendisse nunc hac eleifend amet blandit facilisi condimentum commodo scelerisque faucibus aenean ullamcorper ante mauris dignissim consectetuer nullam lorem vestibulum habitant conubia elementum pellentesque morbi facilisis arcu sollicitudin diam cubilia aptent vestibulum auctor eget dapibus pellentesque inceptos leo egestas interdum nulla consectetuer suspendisse adipiscing pellentesque proin lobortis sollicitudin augue elit mus congue fermentum parturient fringilla euismod feugiat</p><p>Curabitur class aliquam vestibulum nam curae maecenas sed integer cras phasellus suspendisse quisque donec dis praesent accumsan bibendum pellentesque condimentum adipiscing etiam consequat vivamus dictumst aliquam duis convallis scelerisque est parturient ullamcorper aliquet fusce suspendisse nunc hac eleifend amet blandit facilisi condimentum commodo scelerisque faucibus aenean ullamcorper ante mauris dignissim consectetuer nullam lorem vestibulum habitant conubia elementum pellentesque morbi facilisis arcu sollicitudin diam cubilia aptent vestibulum auctor eget dapibus pellentesque inceptos leo egestas interdum nulla consectetuer suspendisse adipiscing pellentesque proin lobortis sollicitudin augue elit mus congue fermentum parturient fringilla euismod feugiat";
        var itemDescription = "Item Description: Pellentesque porta mauris quis interdum vehicula urna sapien ultrices velit nec venenatis dui odio in augue cras posuere enim a cursus convallis neque turpis malesuada erat ut adipiscing neque tortor ac erat";
        var groupDescription = "Group Description: Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus tempor scelerisque lorem in vehicula. Aliquam tincidunt, lacus ut sagittis tristique, turpis massa volutpat augue, eu rutrum ligula ante a ante";

        var earlyHistoryContent = "<p>'Stamford Bridge' is considered to be a corruption of 'Samfordesbrigge' meaning 'the bridge at the sandy ford'.[6] Eighteenth century maps show a 'Stanford Creek' running along the route of what is now a railway line at the back of the East Stand as a tributary of the Thames. The upper reaches of this tributary have been variously known as Billingswell Ditch, Pools Creek and Counters Creek. In mediaeval times the Creek was known as Billingwell Dyche, derived from 'Billing's spring or stream'. It formed the boundary between the parishes of Kensington and Fulham. By the eighteenth century the creek had become known as Counter's Creek which is the name it has retained since.[7] The stream had two local bridges: Stamford Bridge on the Fulham Road (also recorded as Little Chelsea Bridge) and Stanbridge on the Kings Road, now known as Stanley Bridge.The existing Stamford Bridge was built of brick in 1860–2 and has been partly reconstructed since then."+
        "The brand New Stamford Bridge stadium in August 1905" +
        "Chelsea beat West Brom at Stamford Bridge in September 1905"+
        "Stamford Bridge opened in 1877 as a home for the London Athletics Club and was used almost exclusively for that purpose until 1904, when the lease was acquired by brothers Gus and Joseph Mears, who wanted to stage high-profile professional football matches there. However, previous to this, in 1898, Stamford Bridge played host to the World Championship of shinty between Beauly Shinty Club and London Camanachd.[8] Stamford Bridge was built close to Lillie Bridge, an older sports ground which had hosted the 1873 FA Cup Final and the first ever amateur boxing matches (among other things). It was initially offered to Fulham Football Club, but they turned it down for financial reasons. They considered selling the land to the Great Western Railway Company, but ultimately decided to found their own football club instead, Chelsea, to occupy the ground as a rival to Fulham. Noted football ground architect Archibald Leitch, who had also designed Ibrox, Celtic Park, Craven Cottage and Hampden Park, was hired to construct the stadium. In its early days, Stamford Bridge stadium was served by a small railway station, Chelsea and Fulham railway station, which was later closed after World War II bombing.[9]"+
        "Stamford Bridge had an official capacity of around 100,000, making it the second largest ground in England after Crystal Palace. It was used as the FA Cup final venue. As originally constructed, Stamford Bridge was an athletics track and the pitch was initially located in the middle of the running track. This meant that spectators were separated from the field of play on all sides by the width of running track and, on the north and south sides, the separation was particularly large because the long sides of the running track considerably exceeded the length of the football pitch. The stadium had a single stand for 5,000 spectators on the east side. Designed by Archibald Leitch, it is an exact replica of the Johnny Haynes stand he had previously built at the re-developed Craven Cottage (and the main reason why Fulham had chosen not to move into the new ground). The other sides were all open in a vast bowl and thousands of tons of material excavated from the building of the Piccadilly Line provided high terracing for standing spectators exposed to the elements on the west side."+
        "In 1945, Stamford Bridge staged one of the most notable matches in its history. Soviet side FC Dynamo Moscow were invited to tour the United Kingdom at the end of the Second World War and Chelsea were the first side they faced. An estimated crowd of over 100,000 crammed into Stamford Bridge to watch an exciting 3–3 draw, with many spectators on the dog track and on top of the stands.</p>";

        var crisisHistoryContent = "<p>In the early 1970s the club's owners embarked on an ambitious project to renovate Stamford Bridge. However, the cost of building the East Stand escalated out of control after shortages of materials and a builders' strike and the remainder of the ground remained untouched. The increase in the cost, combined with other factors, sent the club into decline. As a part of financial restructuring in the late 1970s, the freehold was separated from the club and when new Chelsea chairman Ken Bates bought the club for £10m in 1982, he did not buy the ground. A large chunk of the Stamford Bridge freehold was subsequently sold to property developers Marler Estates. The sale resulted in a long and acrimonious legal fight between Bates and Marler Estates. Marler Estates was ultimately forced to bankruptcy after a market crash in the early 1990s, allowing Bates to do a deal with its banks and re-unite the freehold with the club."+
        "During the 1984-85 season, following a series of pitch invasions and fights by football hooligans during matches at the stadium, chairman Ken Bates erected an electric perimeter fence between the stands and the pitch – identical to the one which effectively controlled cattle on his dairy farm. However, the electric fence was never turned on and before long it was dismantled, due to the GLC blocking it from being switched on for health and safety reasons.[10]" +
        "With the Taylor Report arising from the Hillsborough disaster being published in January 1990 and ordering all top division clubs to have all seater stadiums in time for the 1994-95 season, Chelsea's plan for a 34,000-seat stadium at Stamford Bridge was given approval by Hammersmith and Fulham council on 19 July 1990.[11]"+
        "The re-building of the stadium commenced again and successive building phases during the 1990s eliminated the original running track. The construction of the 1973 East Stand initiated the process of eliminating the track. All stands, now roofed and all-seater, are immediately adjacent to the pitch. This structure has the effect of concentrating and capturing the noise of supporters. Paradoxically, the noise was louder prior to the 1990s redevelopment, when supporters were dispersed at a distance from the pitch on open terraces, even though average attendances were around half of what they are now. The pitch, the turnstiles, and the naming rights of the club are now owned by Chelsea Pitch Owners, an organisation set up to prevent the stadium from being purchased by property developers again."+
        "KSS Design Group (architects) designed the complete redevelopment of Stamford Bridge Stadium and its hotels, megastore, offices and residential buildings.[12]</p>"

        var standEastViewContent = "<p>Current capacity: 10,925"+
        "The East Stand and Shed End"+
        "The only covered stand when Stamford Bridge was renovated into a football ground in 1905, the East Stand had a gabled corrugated iron roof, with around 6,000 seats and a terraced enclosure. The stand remained until 1973, when it was demolished in what was meant to be the opening phase of a comprehensive redevelopment of the stadium. The new stand was opened at the start of the 1974–75 season, but due to the ensuing financial difficulties at the club, it was the only part of the development to be completed."+
        "The East Stand essentially survives in its 1973 three-tiered cantilevered form, although it has been much refurbished and modernised since. It is the heart of the stadium, housing the tunnel, dugout, dressing rooms, conference room, press centre, AV and commentary box. The middle tier is occupied by facilities, clubs, and executive suites. The upper tier provides spectators with one of the best views of the pitch and it is the only section to have survived the extensive redevelopment of the 90s. Previously, it was the home to away supporters on the bottom tier. However, at the start of the 2005/2006 season, then-manager José Mourinho requested that the family section move to this part of the stand, to boost team morale. Away fans were moved to the shed end.</p>"

        var standWestViewContent="<p>Capacity: 13,500"+
        "The West Stand"+
        "In 1964–65, a seated West Stand was built to replace the existing terracing on the west side. Most of the West Stand consisted of rising ranks of wooden tip up seats on iron frames, but seating at the very front was on concrete forms known as the Benches. The old West Stand was demolished in 1997 and replaced by the current West Stand. It has three tiers, in addition to a row of executive boxes that stretches the length of the stand."+
        "The lower tier was built on schedule and opened in 1998. However, difficulties with planning permission meant that the stand was not fully completed until 2001. Construction of the stand almost caused another financial crisis, which would have seen the club fall into administration, but for the intervention of Roman Abramovich. In borrowing £70m from Eurobonds to finance the project, Ken Bates put Chelsea into a perilous financial position, primarily because of the repayment terms."+
        "The new Stamford Bridge West Stand exterior"+
        "Now complete, the stand is the main external 'face' of the stadium, being the first thing fans see when entering the primary gate on Fulham Road. The Main Entrance is flanked by the Spackman and Speedie hospitality entrances, named after former Chelsea players Nigel Spackman and David Speedie. The stand also features the largest concourse area in the stadium, it is also known as the 'Great Hall' and is used for many functions at Stamford Bridge, including the Chelsea Player of the Year ceremony.</p>"

        // These three strings encode placeholder images. You will want to set the
        // backgroundImage property in your real data to be URLs to images.
        var earlyHistoryBackgroundImage = "http://upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Bird_Eye_Pictures_of_Chelsea%27s_Stamford_Bridge_stadium_1909.jpg/800px-Bird_Eye_Pictures_of_Chelsea%27s_Stamford_Bridge_stadium_1909.jpg"
        var crisisHistoryBackgroundImage="http://www.taprofessional.de/charts/000027BM.GIF"
        var stamfordBridgePanorama = "http://cms.442.haymarketnetwork.com/contentimages/blog/ChampionsLeague/Stamford_Bridge.jpg"
        var standImage = "http://wallapik.com/wp-content/uploads/2013/07/Chelsea-Logo-Wallpaper.jpg";
        var standEastView = "http://upload.wikimedia.org/wikipedia/commons/thumb/3/38/Stamford_Bridge_0066.JPG/800px-Stamford_Bridge_0066.JPG";
        var standWestView = "http://upload.wikimedia.org/wikipedia/commons/thumb/7/7c/Stamford_Bridge_-_West_Stand.jpg/800px-Stamford_Bridge_-_West_Stand.jpg";
        // Each of these sample groups must have a unique key to be displayed
        // separately.
        var sampleGroups = [
            { key: "History", title: "History", subtitle: "Samford Bridge has a long history", backgroundImage: stamfordBridgePanorama, description: groupDescription },
            { key: "Stadium", title: "Stadium", subtitle: "The glory of SamfordBridge", backgroundImage: stamfordBridgePanorama, description: groupDescription },

        ];

        // Each of these sample items should have a reference to a particular
        // group.
        var sampleItems = [
            { group: sampleGroups[0], title: "Early history", subtitle: "Stamford Bridge' is considered to be a...", description: itemDescription, content: earlyHistoryContent, backgroundImage: earlyHistoryBackgroundImage },
            { group: sampleGroups[0], title: "Crisis", subtitle: "the cost of building the East Stand escalated out of control", description: itemDescription, content: crisisHistoryContent, backgroundImage: crisisHistoryBackgroundImage },
            { group: sampleGroups[1], title: "East Stand", subtitle: "East view of the gloriest stadium", description: itemDescription, content: standEastViewContent, backgroundImage: standEastView },
            { group: sampleGroups[1], title: "West Stand", subtitle: "West view of the gloriest stadium", description: itemDescription, content: standWestViewContent, backgroundImage: standWestView },
        ];

        return sampleItems;
    }
})();
