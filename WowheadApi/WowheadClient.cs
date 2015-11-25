﻿using System.Globalization;
using ApiCommon;
using Framework.MVVM;
using WowheadApi.Grabbers;
using WowheadApi.Models;

namespace WowheadApi
{
    public class WowheadClient : ObservableObject
    {
        // itemset   :              http://www.wowhead.com/itemset=1196
        // event     :              http://www.wowhead.com/event=181
        // faction   :              http://www.wowhead.com/faction=1067
        // hunterpet :              http://www.wowhead.com/pets=0
        // haut-fait :              http://www.wowhead.com/achievement=940
        // pet ability :            http://www.wowhead.com/petability=1062
        // mascotte de combat :     http://www.wowhead.com/npc=72098
        // métier :                 http://www.wowhead.com/skill=773
        // monnaies :               http://www.wowhead.com/currency=416
        // pnjs :                   http://www.wowhead.com/npc=15727
        // races :                  http://www.wowhead.com/race=22
        // Sets transmogrifiés :    http://www.wowhead.com/transmog-set=1308
        // sorts/glyphs :           http://www.wowhead.com/spell=86524
        // titres :                 http://www.wowhead.com/title=125
        // zones :                  http://www.wowhead.com/zone=5287

        #region Fields
        private string _baseUrl;
        private string _baseQuery;
        #endregion Fields

        #region Ctor
        public WowheadClient(IDataProvider dataProvider, CultureInfo locale = null)
        {
            System.Diagnostics.Debug.Assert(dataProvider != null, "DataProvider not set");
            DataProvider = dataProvider;
            CurrentLocale = locale ?? LocalizationHelper.DefaultCulture;
        }
        #endregion Ctor

        #region Properties
        public CultureInfo CurrentLocale
        {
            get { return _currentLocale; }
            set
            {
                _currentLocale = value ?? CultureInfo.CurrentCulture;
                RaisePropertyChanged(() => CurrentLocale);
                CurrentLocaleChanged();
            }
        }
        private CultureInfo _currentLocale;

        public IDataProvider DataProvider { get; set; }
        #endregion Properties

        #region Private Methods
        private void CurrentLocaleChanged()
        {
            string localeToken = CurrentLocale.Name.Substring(0, 2);
            _baseUrl = string.Format("http://{0}.wowhead.com/", localeToken);
            _baseQuery = string.Concat(_baseUrl, "{0}={1}");
        }

        private string GetData(string type, int id)
        {
            string address = string.Format(_baseQuery, type, id);
            return DataProvider.ProvideData(address);
        }

        private T Get<T, G>(string type, int id)
            where T : class
            where G : IGrabber<T>, new()
        {
            // retrieve html data
            string data = GetData(type, id);
            // instanciate the grabber
            IGrabber<T> grabber = new G();
            // extract data
            return grabber.Extract(data, id);
        }
        #endregion Private Methods

        #region Public Methods
        /// <summary>
        /// Provides data about an individual item
        /// http://www.wowhead.com/item=99371
        /// </summary>
        /// <param name="id">The item id</param>
        /// <returns>The item</returns>
        public Item GetItem(int id)
        {
            return Get<Item, ItemGrabber>("item", id);
        }

        /// <summary>
        /// Provide data about game objects
        /// http://www.wowhead.com/object=3714
        /// </summary>
        /// <param name="id">The game object id</param>
        /// <returns>The game object</returns>
        public GameObject GetGameObject(int id)
        {
            return Get<GameObject, GameObjectGrabber>("object", id);
        }

        /// <summary>
        /// Provide data about quests
        /// http://www.wowhead.com/quest=9874
        /// </summary>
        /// <param name="id">The quest id</param>
        /// <returns>The quest object</returns>
        public Quest GetQuest(int id)
        {
            return Get<Quest, QuestGrabber>("quest", id);
        }
        #endregion Public Methods
    }
}
