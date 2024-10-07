static string CodeGolf1Andy(string W)

{
    var words = W.Split('\n');
    var rot13Words = new List<string>();

    foreach (var word in words)
    {
        var transformedWord = string.Empty;
        foreach (var c in word)
        {
            if (c >= 'a' && c <= 'z')
            {
                transformedWord += (char)((c - 'a' + 13) % 26 + 'a');
            }
        }
        if (words.Contains(transformedWord))
        {
            rot13Words.Add(transformedWord);
        }
    }

    var uniqueWords = rot13Words.Select(w => w.ToLower()).Distinct().ToList();
    uniqueWords.Sort();
    return string.Join("\n", uniqueWords);
}

static string CleanList(string s)
{
    var words = s.ToLower().Split('\n').Distinct().ToList();
    words.Sort();
    return string.Join("\n", words);
}

static List<Test> Tests()
{

    return new List<Test>
        {
            new Test
            {
                Input = CleanList("cat\nirk\nVex\nTerra\ngreen\ngnat\ntang\ndog\nabcdefghijklmnopqurstuvwxyz"),
                Expect = CleanList("irk\nVex\nTerra\ngreen\ngnat\ntang")
            },
            new Test
            {
                Input = CleanList("za\nAb\naba\nAbba\nAbe\nabjurer\nAbo\nAcieral\nacock\nadoxy\nadvised\nadviser\naefald\naffeer\nAgena\nAh\nah\naha\nahaunch\naho\najowan\nalbe\nalula\nalypin\namesite\namidic\namidin\namylin\nan\nAna\nana\nAnakes\nanalogy\nanan\nanil\nAnn\nann\nanorexy\nant\napaid\nAparai\nar\narba\narc\nareek\nArgyle\nargyria\narn\nArne\nAro\narsheen\narshin\nAsaphic\nassegai\natresic\nAudian\naum\nAvar\nAvertin\navo\navoid\nawesome\nba\nBabiism\nbaler\nbalita\nbalk\nBan\nban\nBana\nbar\nBaraca\nBare\nbare\nbatino\nbauson\nBawra\nbaywood\nbe\nbeamage\nbeamed\nbean\nbecuna\nbedaub\nbeg\nbegrime\nBel\nbel\nbell\nBen\nben\nber\nbes\nbeshlik\nbeyond\nbhang\nbickern\nbimane\nbin\nbirl\nBizonia\nbloat\nblunter\nbolero\nbonded\nBonnie\nboozer\nbor\nborasca\nboun\nboxhaul\nBrava\nbromoil\nbronc\nBu\nbu\nbub\nbucksaw\nbuggy\nbuilt\nbullism\nBunga\nbunny\nbunt\nburion\nbuttery\nbyerite\nCabinda\ncadjan\ncadrans\nCalas\ncalends\ncallus\ncameist\ncant\ncapulet\ncarpent\ncater\ncaution\nCayuga\ncensor\ncha\nchab\nchack\nchal\nchat\nchatta\nche\nChechen\nchee\ncheer\ncheery\nCheney\nchevon\nChian\nchirr\ncho\nchob\nCholo\nchopin\ncity\nclerk\nclouted\nclover\ncoach\ncoder\ncodworm\ncoeval\ncoff\ncolic\ncolor\nconopid\nconsul\ncontra\ncoraise\ncorneum\ncoster\nCoueism\ncougnar\ncouxia\ncowbind\ncoz\ncrag\ncraggan\nCrax\ncrea\ncreel\nCrete\nCrex\ncrissal\ncross\ncrowder\ncub\nCuba\nCuculus\nCullen\ncullion\ncur\ncuvy\ncymar\nczarian\ndabb\ndalles\ndamson\ndand\ndarger\ndecapod\ndecream\ndeeping\ndelible\ndemi\ndeworm\ndhanush\ndhoon\ndidym\ndiehard\ndill\ndineric\ndisglut\ndiss\ndoghole\ndonnish\ndorab\ndoubled\ndowny\ndrop\ndroshky\ndubb\nducker\ndudish\nDuit\nDungan\ndurance\nebony\nehlite\nEjam\neleven\nElla\nElohism\neluder\nen\nenation\nendear\nendew\nenrut\nenvy\ner\nErava\nerg\nerikite\nerne\nerr\ners\nevasive\nfacient\nfaden\nFalisci\nfant\nfaro\nfetish\nfigment\nfilite\nfinless\nfipenny\nfitchet\nFiuman\nflabby\nflap\nflirter\nflyboat\nfogon\nfoiler\nfootle\nforgot\nfra\nfracas\nfraghan\nfrank\nfrater\nfreir\nfu\nfub\nfubby\nfun\nfundic\nfunt\nFur\nfur\nfury\nfusc\ngangdom\nganglia\nGaonate\ngarbel\ngast\nGaul\ngear\ngeat\ngel\ngen\ngena\nGenny\ngent\ngenu\ngerenuk\ngers\nGhan\nghat\nghee\ngist\ngledy\nglee\ngnar\ngnat\ngnawing\ngodpapa\nGordian\nGouda\ngra\ngraddan\ngranter\ngrat\ngreeny\ngrr\ngrummet\ngrutch\nguacin\nguesten\ngul\ngun\nguna\ngunj\ngur\ngurl\ngurr\nha\nhack\nhaler\nhallage\nhan\nhaught\nhaver\nhe\nHein\nhen\nhenotic\nher\nhern\nhetaery\nhexine\nhin\nhippus\nhiro\nHirudin\nhissing\nhoer\nhoghood\nhomo\nhooklet\nhorned\nhowe\nhundi\nhuspil\nhydrula\nhyppish\nideally\nilleck\nimbed\nimburse\nimmi\nimpasse\nincog\nIng\ning\ninteger\nIowan\nIraq\nirk\nisobare\nisocrat\nistle\nIthacan\nIvan\nivin\nivoried\njaunce\njerry\njitters\nJuergen\nJuha\nJun\nJune\njune\njunior\nJura\nkalends\nkeacorn\nkemple\nkialee\nKinch\nkippeen\nkittul\nKohen\nKoli\nKomati\nKoniga\nkulimit\nla\nlaine\nlamb\nlapel\nlaurate\nled\nleeward\nlexia\nliman\nlinin\nlinten\nLipan\nlisper\nloave\nlobcock\nloom\nLuite\nmaestri\nmagiric\nMahra\nmaimer\nmannose\nmano\nmanuao\nmap\nmarcher\nmarcid\nmarried\nMary\nMaun\nmaundy\nmaxim\nmedal\nmeddler\nmentum\nmerfold\nmew\nmho\nmiamia\nmidwise\nmilchy\nmolary\nmolpe\nMoslem\nmousse\nmudden\nmun\nmuricid\nMysidae\nMysore\nmyxa\nna\nnaa\nnag\nnakhod\nnamer\nNan\nnan\nNana\nnana\nnavy\nne\nnea\nneb\nneon\nNep\nnep\nnettler\nnewtake\nnib\nnine\nninon\nnizamut\nno\nnob\nnobby\nnodding\nnodiak\nnon\nnoon\nnor\nnourice\nnowhere\nnu\nnub\nnucleus\nnumeral\nnun\nnunnery\nobe\noctose\nodso\noenin\noff\nogam\nOgor\noh\noho\nomasum\nomitter\non\nOna\nona\nOnan\none\noner\nOniscus\nonyx\noppidan\nor\nora\nore\norf\norlo\norna\norotund\norphan\nort\nory\nosamine\nourie\noutpay\nOva\nova\noverget\novey\npalama\npaludic\npanical\npanisic\nPavia\npenk\npent\nperjury\nperk\npern\nPerry\nperry\nPhil\npho\nphon\nphonics\npickee\npicture\npien\npimpled\npiously\npirl\npit\nplatty\npledger\npollack\npomato\nponerid\nPoria\npostic\npoteye\npoulter\npounce\npowdry\nprefer\nprivy\nprofile\npross\npruner\npsaltes\npsylla\npub\npun\npunatoo\npung\npunicin\nPuno\npuny\npur\npurpura\npurr\npurre\npurrel\npusscat\nPyrex\npyrex\npyropen\npyropus\nQuader\nqubba\nra\nRabi\nrabitic\nrail\nrappage\nrarity\nre\nreaal\nrear\nrebend\nredcoat\nredweed\nRee\nree\nRees\nref\nregrasp\nreluct\nrenin\nreplate\nreseize\nresidua\nret\nretour\nretral\nrheic\nrhymer\nrife\nrifling\nripping\nrobing\nrohuna\nRomanly\nRomic\nrookish\nrumor\nrupial\nsairve\nsaltant\nsaltery\nsalvo\nsamekh\nscissel\nscraw\nscrubby\nseafolk\nseaware\nseldor\nsen\nSerer\nserve\nsetness\nseton\nsetsman\nsetting\nsettlor\nsex\nsexto\nsh\nsha\nshag\nshave\nshe\nshedded\nShel\nsher\nSho\nsho\nshool\nshowish\nshrinal\nshrip\nShrove\nsievy\nsinus\nsinusal\nsirrah\nsis\nskither\nslait\nsley\nslicken\nslinker\nsloven\nsmoker\nsnag\nsnap\nsnath\nsneb\nsniping\nsnithe\nsoiling\nsort\nsourer\nSpalax\nspent\nspex\nspidger\nspirt\nspiry\nspryly\nspyship\nsqualor\nstilt\nstrive\nstrue\nStyrian\nsucuriu\nSuevi\nsummary\nsumpter\nsundry\nSwahili\nsylphy\nsync\ntaccada\ntalao\ntane\nTang\ntang\ntanghin\ntanglad\ntankert\nTarazed\ntarve\ntaxon\ntealery\nteaser\nTecuna\ntee\ntelical\nten\nteng\ntercio\nterral\nterrify\ntestily\ntha\nthan\nthaw\nThe\nthe\nthecate\nthee\ntheft\nthey\nthistle\nthob\nthole\nthone\nthorny\nthy\nthymoma\ntimawa\ntiphead\ntitrate\ntoadess\ntomnoup\ntomosis\ntoplike\nToryess\ntra\ntrag\ntrah\ntrain\nTran\ntref\ntremble\ntriarch\ntrilobe\ntry\ntubbie\ntueiron\ntumored\nTuna\ntuna\ntung\ntuning\nturfdom\nturr\ntweil\nTyrr\nulcery\nun\nUna\nunaloud\nunfrank\nunionid\nunkeyed\nunlit\nunmount\nunoften\nunpiety\nunscent\nunspike\nunurban\nunwhig\nunwon\nupperch\nuprid\nur\nura\nure\nurea\nUrocyon\nurva\nusurp\nuta\nUtopian\nuva\nvacancy\nvacuist\nValkyr\nValois\nvapored\nvari\nvat\nVejoces\nVend\nvend\nverd\nvesbite\nvesicae\nvex\nvictim\nvina\nvitals\nviva\nWalloon\nWarori\nwarp\nwaucht\nwearily\nweblike\nwedded\nweftage\nwha\nwhample\nwhar\nwhen\nwhence\nwhites\nwhorish\nwhun\nWilhelm\nwincey\nwog\nwoodlet\nwouch\nwuzzer\nYakona\nyamp\nYaru\nYerava\nYezdi\nym\nyn\nzimme"),
                Expect = CleanList("Ab\naba\nAbba\nAbe\nabjurer\nAbo\nAh\nah\naha\naho\nan\nAna\nana\nanan\nanil\nAnn\nann\nant\nar\narba\narc\narn\nAro\nAvar\navo\nba\nbalk\nBan\nban\nBana\nbar\nBare\nbare\nbe\nbean\nbecuna\nbeg\nBel\nbel\nBen\nben\nber\nbes\nbin\nbirl\nbor\nBrava\nBu\nbu\nbub\ncha\nchab\nchal\nchat\nche\nChechen\nchee\ncheer\ncheery\ncho\nclerk\ncrag\nCrax\ncrea\ncreel\nCrex\ncub\nCuba\ncuvy\ndhoon\nen\nenvy\ner\nErava\nerg\nerne\nerr\ners\nfant\nfaro\nflap\nfra\nfreir\nfu\nfub\nfubby\nfun\nfunt\nFur\nfur\nfury\ngel\ngen\ngena\ngent\ngenu\ngers\nGhan\nghat\nghee\nglee\ngnar\ngnat\ngra\ngrat\ngreeny\ngrr\ngul\ngun\nguna\ngunj\ngur\ngurl\ngurr\nha\nhan\nhe\nHein\nhen\nher\nhern\nhin\nIng\ning\nIraq\nirk\nIvan\nivin\nJuha\nJun\nJune\njune\nJura\nla\nna\nnaa\nnag\nNan\nnan\nNana\nnana\nnavy\nne\nnea\nneb\nneon\nNep\nnep\nnib\nnine\nno\nnob\nnon\nnoon\nnor\nnowhere\nnu\nnub\nnun\nobe\noenin\noh\noho\non\nOna\nona\nOnan\none\noner\nonyx\nor\nora\nore\norf\norna\norphan\nort\nory\nOva\nova\novey\npenk\npent\nperk\npern\nPerry\nperry\nPhil\npho\nphon\npub\npun\npung\nPuno\npuny\npur\npurpura\npurr\npurre\npurrel\nPyrex\npyrex\nqubba\nra\nrail\nre\nrear\nRee\nree\nref\nrenin\nret\nsen\nserve\nsh\nsha\nshag\nshe\nShel\nSho\nsho\nshool\nsnag\nsneb\nsync\ntane\nTang\ntang\ntee\nten\nteng\nterral\ntha\nthan\nthaw\nThe\nthe\nthee\nthey\nthy\ntra\ntrag\ntrah\nTran\ntref\ntry\nTuna\ntuna\ntung\nturr\nTyrr\nun\nUna\nur\nura\nure\nurea\nurva\nuva\nvat\nVend\nvend\nvex\nvina\nviva\nwha\nwhar\nwhen\nwhun\nyn")
            }
        };

}

/* Main method */
const int timerCount = 1111;
var tests = Tests();
var stopwatch = new System.Diagnostics.Stopwatch();

foreach (var test in tests)
{
    var result = CodeGolf1Andy(test.Input);
    if (result == test.Expect)
    {
        Console.WriteLine("Test passed.");
    }
    else
    {
        Console.WriteLine("Test failed.");
        Console.WriteLine($"Expected: {test.Expect}");
        Console.WriteLine($"Got: {result}");
    }
}

double totalElapsedTime = 0;
for (int i = 0; i < timerCount; i++)
{
    stopwatch.Start();
    foreach (var test in tests)
    {
        var result = CodeGolf1Andy(test.Input);
        // var expect = CodeGolf1Andy(test.Expect);
    }
    stopwatch.Stop();
    totalElapsedTime += stopwatch.Elapsed.TotalMilliseconds;
    stopwatch.Reset();
}
double averageTime = totalElapsedTime / timerCount;
Console.WriteLine($"Average time: {averageTime:F2} ms");


class Test
{
    public string Input { get; set; } = string.Empty;
    public string Expect { get; set; } = string.Empty;
}

