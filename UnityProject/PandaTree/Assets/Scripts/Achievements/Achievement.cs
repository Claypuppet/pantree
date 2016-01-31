using System.Collections.Generic;
using System.Linq;

public class Achievement {

    private AchievementManager mManager;
    private AchievementDefinition mDefinition;
    private AchievementProgress mProgress;

    public Achievement(AchievementManager manager, AchievementDefinition definition, AchievementProgress progress) {
        mManager = manager;
        mDefinition = definition;
        mProgress = progress;
    }

    public class ValueT<T> {
        Achievement mAchievement;
        AchievementDefinition.Value mValue;

        public ValueT(Achievement achievement, AchievementDefinition.Value value) {
            mAchievement = achievement;
            mValue = value;
        }

        public T Value {
            get {
                return mValue.GetValue<T>();
            }
            set {
                var old = mValue.ValueString;
                mValue.SetValue<T>(Value);
                if(!old.Equals(mValue.ValueString)) {
                    mAchievement.mManager.OnProgressed(mAchievement, mAchievement.mProgress, mValue);
                }
            }
        }
    }


    public string Id { get { return mDefinition.Id; } }
    public string Name { get { return mDefinition.Name; } }
    public string Description { get { return mDefinition.Description; } }
    public string Icon { get { return mDefinition.Icon; } }
    public bool Secret { get { return mDefinition.Secret; } }

    public ValueT<T> GetDefinitionValue<T>(string id) {
        if(mDefinition.Values != null) {
            var q = from v in mDefinition.Values
                    where v.Id == id
                    select v;
            AchievementDefinition.Value value = q.First();
            if(value != null)
                return new ValueT<T>(this, value);
        }
        return null;
    }

    public ValueT<T> GetDefinitionValue<T>(int index) {
        if(mDefinition.Values != null && index < mDefinition.Values.Count) {
            return new ValueT<T>(this, mDefinition.Values.ElementAt(index));
        }
        return null;
    }

    public ValueT<T> GetProgessionValue<T>(string id, bool createIfNotExist=true) {

        AchievementDefinition.Value value = null;
        if(mProgress.Values != null) {
            var q = from v in mProgress.Values
                    where v.Id != null && v.Id == id
                    select v;
            value = q.First();
        }

        if(value == null && createIfNotExist) {
            id = id.Trim();
            if(id.Length > 0) {
                value = new AchievementDefinition.Value();
                value.Id = id;
                mProgress.Values.Add(value);
            }
        }

        if(value != null)
            return new ValueT<T>(this, value);
        return null;
    }

    public bool HasAchieved() {
        return mProgress.Achieved.Value;
    }

    public void Achieved() {
        if(!mProgress.Achieved.Value) {
            mProgress.Achieved.Value = true;
            mManager.OnAchieved(this, mProgress);
        }
    }


}
