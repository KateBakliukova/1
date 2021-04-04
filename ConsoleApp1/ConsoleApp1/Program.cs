using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static string a = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Turpis egestas integer eget aliquet nibh praesent. Viverra suspendisse potenti nullam ac tortor vitae purus faucibus. Mattis molestie a iaculis at erat pellentesque adipiscing commodo. Enim neque volutpat ac tincidunt vitae. Lacinia at quis risus sed vulputate odio ut enim. Adipiscing commodo elit at imperdiet dui. Egestas diam in arcu cursus euismod quis viverra. Lectus nulla at volutpat diam ut. Erat nam at lectus urna duis convallis convallis. Ut porttitor leo a diam sollicitudin tempor. Velit ut tortor pretium viverra suspendisse potenti. Posuere sollicitudin aliquam ultrices sagittis orci a scelerisque purus. Habitasse platea dictumst quisque sagittis purus sit amet. Tortor posuere ac ut consequat. Metus aliquam eleifend mi in. Habitasse platea dictumst quisque sagittis purus. Lorem ipsum dolor sit amet consectetur adipiscing elit pellentesque.
Ultrices gravida dictum fusce ut placerat. Dolor morbi non arcu risus quis varius.Ut ornare lectus sit amet est placerat in egestas erat. Diam volutpat commodo sed egestas egestas. Sit amet risus nullam eget felis eget.Nulla facilisi etiam dignissim diam quis enim lobortis scelerisque fermentum. Sit amet mauris commodo quis imperdiet massa.Platea dictumst vestibulum rhoncus est pellentesque elit.Mattis ullamcorper velit sed ullamcorper morbi tincidunt.Eget gravida cum sociis natoque penatibus. Non arcu risus quis varius quam quisque id diam.
Lectus urna duis convallis convallis tellus. Bibendum arcu vitae elementum curabitur vitae nunc sed velit dignissim. Morbi tristique senectus et netus et. Pharetra vel turpis nunc eget lorem dolor.Platea dictumst quisque sagittis purus sit amet volutpat consequat mauris. Amet dictum sit amet justo.Blandit volutpat maecenas volutpat blandit aliquam etiam.Orci sagittis eu volutpat odio facilisis mauris sit. Sed vulputate mi sit amet mauris commodo quis. Nunc vel risus commodo viverra maecenas. Et malesuada fames ac turpis egestas sed tempus urna et. Hendrerit gravida rutrum quisque non tellus orci.
Magna ac placerat vestibulum lectus mauris ultrices eros in cursus.At ultrices mi tempus imperdiet nulla malesuada pellentesque elit eget. Sit amet aliquam id diam maecenas ultricies.Non nisi est sit amet facilisis magna etiam tempor orci. Felis bibendum ut tristique et.Vitae nunc sed velit dignissim sodales ut eu. Sit amet mattis vulputate enim.Eget sit amet tellus cras adipiscing enim eu turpis egestas. Sed nisi lacus sed viverra tellus in hac habitasse. Quisque id diam vel quam.In dictum non consectetur a erat. Non diam phasellus vestibulum lorem sed risus.In pellentesque massa placerat duis ultricies lacus sed turpis.Eget lorem dolor sed viverra.Ut sem viverra aliquet eget sit. Tellus molestie nunc non blandit massa. Habitant morbi tristique senectus et netus et.Tincidunt tortor aliquam nulla facilisi cras.
Quam pellentesque nec nam aliquam.In cursus turpis massa tincidunt dui ut ornare lectus.Eget mi proin sed libero enim. Iaculis urna id volutpat lacus.Et pharetra pharetra massa massa ultricies. Euismod in pellentesque massa placerat duis ultricies lacus sed turpis. Id nibh tortor id aliquet lectus. Lacus luctus accumsan tortor posuere ac ut consequat. Tempus quam pellentesque nec nam aliquam sem et tortor.Nulla facilisi nullam vehicula ipsum a arcu.Adipiscing bibendum est ultricies integer.Est ullamcorper eget nulla facilisi etiam dignissim diam quis.Sem viverra aliquet eget sit amet tellus cras. Vel fringilla est ullamcorper eget nulla facilisi etiam dignissim diam. Nulla aliquet enim tortor at auctor urna.Sed risus pretium quam vulputate dignissim suspendisse in est ante. Sapien pellentesque habitant morbi tristique senectus et netus et.Vitae congue eu consequat ac felis donec.Nec nam aliquam sem et tortor consequat id. Fermentum iaculis eu non diam phasellus.
Purus ut faucibus pulvinar elementum integer. Consequat nisl vel pretium lectus.Diam quis enim lobortis scelerisque fermentum. Diam vulputate ut pharetra sit amet aliquam id. Amet risus nullam eget felis eget nunc.Massa placerat duis ultricies lacus sed turpis tincidunt. Sed viverra tellus in hac habitasse platea.Tellus id interdum velit laoreet id. Consectetur libero id faucibus nisl tincidunt eget nullam non nisi. Vulputate odio ut enim blandit volutpat maecenas volutpat. Ultrices eros in cursus turpis massa.Quam id leo in vitae turpis massa sed. Nam libero justo laoreet sit amet cursus.Orci dapibus ultrices in iaculis.Id porta nibh venenatis cras sed felis eget velit.A condimentum vitae sapien pellentesque habitant. Bibendum at varius vel pharetra vel turpis nunc eget.Pulvinar elementum integer enim neque volutpat ac tincidunt. Vitae suscipit tellus mauris a diam maecenas sed.
Suspendisse faucibus interdum posuere lorem.Sed augue lacus viverra vitae congue eu.Tortor condimentum lacinia quis vel eros donec ac odio.Dignissim sodales ut eu sem integer vitae justo eget.In hac habitasse platea dictumst.Morbi leo urna molestie at elementum eu facilisis sed odio. In cursus turpis massa tincidunt dui ut ornare lectus.Auctor elit sed vulputate mi sit amet mauris. Amet nulla facilisi morbi tempus iaculis. Varius quam quisque id diam vel quam elementum. Quis varius quam quisque id diam vel quam elementum pulvinar. Rhoncus est pellentesque elit ullamcorper.Donec enim diam vulputate ut pharetra sit.In ante metus dictum at.Sed turpis tincidunt id aliquet risus feugiat.Elementum tempus egestas sed sed.Scelerisque eu ultrices vitae auctor eu. Ut tellus elementum sagittis vitae et leo duis ut diam. Sagittis aliquam malesuada bibendum arcu vitae elementum curabitur vitae nunc.
Pulvinar sapien et ligula ullamcorper malesuada. Nisl suscipit adipiscing bibendum est ultricies integer quis auctor.Eu feugiat pretium nibh ipsum consequat nisl.Ipsum faucibus vitae aliquet nec ullamcorper sit amet. Enim ut sem viverra aliquet eget. Quis risus sed vulputate odio ut enim.Vel eros donec ac odio tempor orci dapibus ultrices in. Nibh cras pulvinar mattis nunc sed blandit.Euismod elementum nisi quis eleifend.Sed vulputate odio ut enim blandit volutpat maecenas volutpat.Ornare quam viverra orci sagittis.Eget aliquet nibh praesent tristique magna sit amet purus gravida. Non odio euismod lacinia at.Orci nulla pellentesque dignissim enim sit.
Id interdum velit laoreet id donec. Senectus et netus et malesuada fames ac turpis. Venenatis urna cursus eget nunc scelerisque viverra mauris in. Blandit volutpat maecenas volutpat blandit aliquam etiam erat. Duis convallis convallis tellus id interdum velit laoreet id.Nisi lacus sed viverra tellus in. Sociis natoque penatibus et magnis dis parturient montes. In ante metus dictum at tempor. Fermentum dui faucibus in ornare quam viverra orci sagittis.Hendrerit gravida rutrum quisque non tellus. Sit amet massa vitae tortor condimentum lacinia quis vel.Sit amet mauris commodo quis imperdiet massa tincidunt nunc pulvinar. Nibh tortor id aliquet lectus proin nibh nisl. Eleifend donec pretium vulputate sapien nec sagittis aliquam. Augue ut lectus arcu bibendum at varius vel pharetra.Curabitur gravida arcu ac tortor dignissim convallis aenean et.In nisl nisi scelerisque eu ultrices vitae auctor. Sociis natoque penatibus et magnis dis parturient montes nascetur.Pellentesque elit ullamcorper dignissim cras tincidunt lobortis feugiat vivamus at. Dui faucibus in ornare quam.
Faucibus turpis in eu mi bibendum.Massa sapien faucibus et molestie ac feugiat sed lectus.Vivamus at augue eget arcu dictum. Turpis in eu mi bibendum neque egestas congue quisque.Sit amet nulla facilisi morbi tempus iaculis urna id.Habitant morbi tristique senectus et.Nunc congue nisi vitae suscipit tellus mauris a diam.Id diam maecenas ultricies mi eget mauris pharetra et ultrices. Nulla porttitor massa id neque aliquam vestibulum morbi blandit.Egestas sed sed risus pretium quam. Est ultricies integer quis auctor.Amet tellus cras adipiscing enim eu turpis egestas pretium aenean. Ullamcorper dignissim cras tincidunt lobortis feugiat. Dictum varius duis at consectetur lorem. Et malesuada fames ac turpis egestas maecenas pharetra convallis.
Mi tempus imperdiet nulla malesuada pellentesque elit eget gravida cum. At ultrices mi tempus imperdiet nulla malesuada pellentesque. Morbi quis commodo odio aenean sed. Volutpat commodo sed egestas egestas fringilla phasellus faucibus. Quis lectus nulla at volutpat diam. Id eu nisl nunc mi.Faucibus in ornare quam viverra orci sagittis eu volutpat odio. Consequat interdum varius sit amet mattis vulputate enim. Et netus et malesuada fames ac. Id nibh tortor id aliquet lectus proin nibh nisl condimentum. Eleifend quam adipiscing vitae proin sagittis nisl rhoncus.
Non pulvinar neque laoreet suspendisse interdum consectetur.Nulla facilisi morbi tempus iaculis urna id volutpat. Cursus risus at ultrices mi.Euismod lacinia at quis risus sed. Id ornare arcu odio ut.Dignissim diam quis enim lobortis scelerisque fermentum dui. Tortor aliquam nulla facilisi cras fermentum odio eu. Nisi quis eleifend quam adipiscing.Eu ultrices vitae auctor eu augue ut lectus arcu bibendum. Nunc scelerisque viverra mauris in aliquam.Amet tellus cras adipiscing enim eu turpis egestas pretium aenean. Lectus proin nibh nisl condimentum id venenatis.
Fusce ut placerat orci nulla.Congue quisque egestas diam in. Quisque id diam vel quam elementum pulvinar etiam. Elementum pulvinar etiam non quam.Adipiscing enim eu turpis egestas pretium aenean pharetra. Bibendum enim facilisis gravida neque convallis. Quam vulputate dignissim suspendisse in est ante. Quis vel eros donec ac odio tempor orci dapibus.Eu consequat ac felis donec et odio pellentesque. Mauris pellentesque pulvinar pellentesque habitant morbi. Mattis enim ut tellus elementum sagittis. Id venenatis a condimentum vitae sapien pellentesque habitant. Id semper risus in hendrerit gravida. Semper feugiat nibh sed pulvinar proin gravida hendrerit lectus a. Urna condimentum mattis pellentesque id nibh tortor id aliquet.Arcu non odio euismod lacinia at quis risus. Id aliquet lectus proin nibh nisl condimentum id venenatis.Aliquet risus feugiat in ante metus dictum at tempor.Quis imperdiet massa tincidunt nunc pulvinar sapien et ligula.
Sapien faucibus et molestie ac feugiat. Venenatis urna cursus eget nunc scelerisque viverra.Mattis aliquam faucibus purus in massa tempor. Scelerisque viverra mauris in aliquam sem fringilla ut morbi.Netus et malesuada fames ac turpis egestas integer eget aliquet. Ullamcorper dignissim cras tincidunt lobortis feugiat vivamus at augue.Lectus urna duis convallis convallis tellus id.Pharetra massa massa ultricies mi quis. Nunc non blandit massa enim nec. Praesent elementum facilisis leo vel.Pulvinar proin gravida hendrerit lectus.Sed pulvinar proin gravida hendrerit.Consectetur adipiscing elit ut aliquam purus sit amet luctus venenatis. Lobortis elementum nibh tellus molestie nunc non blandit massa enim. Est ultricies integer quis auctor elit. Placerat vestibulum lectus mauris ultrices.Purus semper eget duis at tellus at urna condimentum.Praesent semper feugiat nibh sed pulvinar proin gravida.
Ac tortor vitae purus faucibus.A condimentum vitae sapien pellentesque habitant morbi tristique. Tortor consequat id porta nibh venenatis cras sed felis eget. Ut venenatis tellus in metus vulputate eu scelerisque felis imperdiet. Semper quis lectus nulla at volutpat. A iaculis at erat pellentesque adipiscing commodo elit at.Facilisi nullam vehicula ipsum a arcu cursus vitae congue mauris. Congue quisque egestas diam in arcu cursus euismod quis. Nunc eget lorem dolor sed viverra ipsum nunc aliquet bibendum. Nulla pharetra diam sit amet nisl. Elementum curabitur vitae nunc sed velit dignissim sodales ut.Sed sed risus pretium quam vulputate dignissim.Vitae semper quis lectus nulla at volutpat diam. Neque convallis a cras semper auctor neque.Adipiscing elit ut aliquam purus sit amet luctus. At quis risus sed vulputate odio. Amet consectetur adipiscing elit pellentesque.Posuere lorem ipsum dolor sit.Fermentum leo vel orci porta.";

        public static string path1 = @"C:\file1.txt";
        public static string path2 = @"C:\file2.txt";
        public static string path3 = @"C:\file3.txt";
        public static string[] b = a.Split(new[] { "\r\n", "\r", "\n" }, System.StringSplitOptions.None);
        public static int numThreads = b.Length;

        static async Task Main(string[] args)
        {
            ////один пишет в один поток синхронно (или асинхронно, это не принципиально)
            //await OneTaskOneFile();

            ////второй пишет в n потоков в файл так
            //await NTaskOneFile();
            
            ////каждый поток пишет в свой файл, а потом один поток склеивает их в правильном порядке)
            //await NTaskNFile(numThreads, b);

            BenchmarkRunner.Run<Program>();
        }

        [Benchmark]
        public async Task OneTaskOneFile()
        {
            using (StreamWriter sw = new StreamWriter(path1, true, System.Text.Encoding.Default))
            {
                await sw.WriteLineAsync(a);
            }
        }

        [Benchmark]
        public async Task NTaskOneFile()
        {
            try
            {
                var taskArr = new List<Task>();
                for (int i = 0; i < numThreads; i++)
                {
                    taskArr.Add(WriteTask(b[i], path2));
                }
                await Task.WhenAll(taskArr.ToArray());
            } catch { }
        }

        [Benchmark]
        public async Task NTaskNFile()
        {
            var taskArr = new List<Task>();
            for (int i = 0; i < numThreads; i++)
            {
                taskArr.Add(WriteTask(b[i], $"C:\\f{i}.txt"));
            }
            await Task.WhenAll(taskArr.ToArray());
            await GlueAll(numThreads);
        }

        static async Task WriteTask(string str, string path)
        {
            using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                await sw.WriteLineAsync(str);
                sw.Close();
            }
        }

        static async Task GlueAll(int pathsNum)
        {
            using (StreamWriter sw = new StreamWriter(path3, false, System.Text.Encoding.Default))
            {
                for (int i = 0; i < pathsNum; i++)
                {
                    using (StreamReader sr = new StreamReader($"C:\\f{i}.txt"))
                    {
                        await sw.WriteAsync(await sr.ReadToEndAsync());
                    }
                }
            }
        }

    }
}
