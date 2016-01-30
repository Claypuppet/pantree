using UnityEngine;
using System.Collections;
using System.Timers;
using System;

public abstract class Season {

    // Add more propeties
    public string name;
    protected int minDuration;
    protected int maxDuration;

    public int GetSeasonDuration() {
        return new System.Random().Next(this.minDuration, this.maxDuration);
    }


    // Static timer stuff
    private static Timer timer;
    private static Action callback;

    public static void StartTimer(int seconds, Action cb) {
        callback = cb;
        timer = new Timer(seconds);
        timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
        timer.Start();
    }

    private static void OnTimedEvent(object source, ElapsedEventArgs e) {
        timer.Dispose();
        callback();
    }
}
