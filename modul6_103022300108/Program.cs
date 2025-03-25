// See https://aka.ms/new-console-template for more information

using modul6_103022300108;

class Run {
    static void Main() {
        SayaTubeVideo vid1 = new SayaTubeVideo("Review Film Narnia oleh Sidqi");
        SayaTubeVideo vid2 = new SayaTubeVideo("Review Film Interstellar oleh Sidqi");
        SayaTubeVideo vid3 = new SayaTubeVideo("Review Film John Wick oleh Sidqi");
        SayaTubeVideo vid4 = new SayaTubeVideo("Review Film John Wick 2 oleh Sidqi");
        SayaTubeVideo vid5 = new SayaTubeVideo("Review Film John Wick 3 oleh Sidqi");
        SayaTubeVideo vid6 = new SayaTubeVideo("Review Film John Wick 4 oleh Sidqi");
        SayaTubeVideo vid7 = new SayaTubeVideo("Review Film BCS oleh Sidqi");
        SayaTubeVideo vid8 = new SayaTubeVideo("Review Film Sicario oleh Sidqi");
        SayaTubeVideo vid9 = new SayaTubeVideo("Review Film Seven oleh Sidqi");
        SayaTubeVideo vid10 = new SayaTubeVideo("Review Film Blacklist oleh Sidqi");

        SayaTubeUser user = new SayaTubeUser("Sidqi Athallah Ar");

        user.AddVideo(vid1);
        user.AddVideo(vid2);
        user.AddVideo(vid3);
        user.AddVideo(vid4);
        user.AddVideo(vid5);
        user.AddVideo(vid6);
        user.AddVideo(vid7);
        user.AddVideo(vid8);
        user.AddVideo(vid9);
        user.AddVideo(vid10);

        user.PrintAllVideoPlayCount();



    }
}
