﻿using BookCategorize.Models;
using Microsoft.EntityFrameworkCore;

namespace BookCategorize.Data
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
        {
        }

        public DbSet<SearchBookModel> searchBookModels { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Volumeinfo> Volumeinfo { get; set; }
        public DbSet<Searches> Searches { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookGoogledatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Volumeinfo>()
            .Property(e => e.authors)
            .HasConversion(
                v => string.Join(',', v),
                v => v.Split(',', StringSplitOptions.RemoveEmptyEntries));
            //modelBuilder.Entity<Volumeinfo>()
            //         .Property(e => e.categories)
            //         .HasConversion(
            //          v => string.Join(',', v),
            //          v => v.Split(',', StringSplitOptions.RemoveEmptyEntries));

            //modelBuilder.Entity<SearchBookModel>().ToTable("Enrollment");
            //modelBuilder.Entity<Volumeinfo>().ToTable("Books");
            //modelBuilder.Entity<Volumeinfo>()
            //    .HasData(new Volumeinfo
            //    {
            //        title = "Meditations",
            //        authors = "Marco Aurelio"[],
            //        publishedDate = 
            //    }
        }
    }
}
//76  Meditations Marco Aurelio (Emperador de Roma)	2006 - 04 - 27 < b >< b > A leading translation of Stoic philosophy in wise and practical aphorisms that have inspired Bill Clinton, Ryan Holiday, Anna Kendrick and many more.</b> <p></b>Written in Greek by an intellectual Roman emperor without any intention of publication, the Meditations of Marcus Aurelius offer a wide range of fascinating spiritual reflections and exercises developed as the leader struggled to understand himself and make sense of the universe. Spanning from doubt and despair to conviction and exaltation, they cover such diverse topics as the question of virtue, human rationality, the nature of the gods and the values of leadership. But while the Meditations were composed to provide personal consolation, in developing his beliefs Marcus also created one of the greatest of all works of philosophy: a series of wise and practical aphorisms that have been consulted and admired by statesmen, thinkers and ordinary readers for almost two thousand years. <p>To provide a full understanding of Aurelius's seminal work, this edition includes explanatory notes, a general index, an index of quotations, an index of names, and an introduction by Diskin Clay putting the work in its biographical, historical, and literary context, a chronology of Marcus Aurelius's life and career. <p>For more than seventy years, Penguin has been the leading publisher of classic literature in the English-speaking world. With more than 1,700 titles, Penguin Classics represents a global bookshelf of the best works throughout history and across genres and disciplines. Readers trust the series to provide authoritative texts enhanced by introductions and notes by distinguished scholars and contemporary authors, as well as up-to-date translations by award-winning translators.	http://books.google.com/books/content?id=QV0wAAAAYAAJ&printsec=frontcover&img=1&zoom=5&imgtk=AFLRE71M3M35voPiaKquj4tbTiSjgfO-t0vzkFYCQxrPQ8HmOeAANmI3R_ktiQEXlqa1GVLgufdkbrXf_-5vzuOC9DIgVMtLywAhFrR-PHm0N1GyX9dMXWL6UpTFt1Q1P7DVB2YZGKFB&source=gbs_api	1	2021-12-18 23:21:24	0
//77  1984    George Orwell	2017-12	1984, published in 1949, is a dystopian and satirical novel. It revolves around Winston Smith, who lives in a nation called Oceania, in a province called Airstrip One, which represents present-day England. This state is controlled by the Party, headed by a mysterious leader who is addressed as Emmanuel Goldstein, also known as the Big Brother. The Party watches every single move that Smith and other citizens make. <p>The nation's language and history is forcefully changed for the benefit of the Party. A new language, Newspeak, is being compulsively implemented to ensure works that have anything to do with political rebellion are omitted. In Oceania, even rebellious thoughts are illegal and are said to be the worst of all crimes. The people are suppressed and any form of individuality is not tolerated, including love and sex.</p> <p>Smith works as a low-ranking member of the Party who alters historical records. He hates the Party and thus buys an illegal diary in which he pens down his thoughts. He meets Julia, a coworker, who seems to been romantically inclined towards him. He however doubts that she is a Party spy who will get him imprisoned for his 'thoughtcrimes'. Her love turns out to be true and they have a covert affair. Smith's hatred for the Party grows day by day and he is convinced that a powerful Party official O'Brien is actually trying to overthrow the present government with the help of a secret group named the Brotherhood. As the story goes on, readers learn the twists and turns that life in Oceania has in store for Smith. He faces terror, betrayal, freedom, and a broken spirit.</p> <p>1984 is the author's haunting vision of the future. The book has been adapted into television programmes, films, radio broadcasts and plays. In 2003, the book was number 8 on BBC's survey The Big Read. It was 6th and 13th on the reader's and editor's list of Modern Library 100 Best Novels, respectively. In 2005, it was added to the 100 Best English Language Novel from 1923 to 2005 by TIME magazine.</p> <p>ABOUT THE AUTHOR:</p> <p>Eric Arthur Blair, better known by his pen name George Orwell (1903-1950), was an English author and journalist. His work is marked by keen intelligence and wit, a profound awareness of social injustice, an intense opposition to totalitarianism, a passion for clarity in language, and a belief in democratic socialism.</p> <p>In addition to his literary career Orwell served as a police officer with the Indian Imperial Police in Burma from 1922-1927 and fought with the Republicans in the Spanish Civil War from 1936-1937. He was severely wounded when he was shot through his throat.</p> <p>Orwell and his wife were accused of 'Rabid Trotskyism' and tried in absentia in Barcelona, along with other leaders of the POUM, in 1938. However by then they had escaped from Spain and returned to England.</p> <p>Between 1941 and 1943, Orwell worked on propaganda for the BBC. In 1943, he became literary editor of the Tribune, a weekly left-wing magazine. He was a prolific polemical journalist, article writer, literary critic, reviewer, poet and writer of fiction, and considered perhaps the twentieth century's best chronicler of English culture.</p> <p>Orwell is best known for the dystopian novel Nineteen Eighty-Four (published in 1949) and the satirical novella Animal Farm (1945)-they have together sold more copies than any two books by any other twentieth-century author. His 1938 book Homage to Catalonia, an account of his experiences as a volunteer on the Republican side during the Spanish Civil War, together with numerous essays on politics, literature, language, and culture, are widely acclaimed. In 2008, The Times ranked him second on a list of 'The 50 greatest British writers since 1945'.</p>	http://books.google.com/books/content?id=aPlAtgEACAAJ&printsec=frontcover&img=1&zoom=5&imgtk=AFLRE71hR8XQ5QzJAofLjzbjOMsLkV2DPTJEfq1fsVLSMbX7qX-Lg02MgB97o3xRLyXnYSrbURySOKi0LhzDZVc30TjGP5PRzp9QyAQHZhf3gY9cNt3gHURLahWoy1V1tcGmxTStp3Dd&source=gbs_api	1	2021-12-18 23:21:41	0
//78  Harry Potter and the Philosopher's Stone	J. K. Rowling	2014-01-09	Celebrate 20 years of Harry Potter magic! Harry Potter has never even heard of Hogwarts when the letters start dropping on the doormat at number four, Privet Drive. Addressed in green ink on yellowish parchment with a purple seal, they are swiftly confiscated by his grisly aunt and uncle. Then, on Harry's eleventh birthday, a great beetle-eyed giant of a man called Rubeus Hagrid bursts in with some astonishing news: Harry Potter is a wizard, and he has a place at Hogwarts School of Witchcraft and Wizardry. An incredible adventure is about to begin!These new editions of the classic and internationally bestselling, multi-award-winning series feature instantly pick-up-able new jackets by Jonny Duddle, with huge child appeal, to bring Harry Potter to the next generation of readers. It's time to PASS THE MAGIC ON ...	http://books.google.com/books/publisher/content?id=HksgDQAAQBAJ&printsec=frontcover&img=1&zoom=5&imgtk=AFLRE72DXwtp10sGer6oG5LJOiYgAmhHumQ2411e51t15Tdy0CabdkY2leO2xL13pLjqoTFtJQCxgRnX8hEfu6gz5E4l7FFroxeR3KT-hOaH5d4cg1TQ-PjWvFzwKJ0jODS7YiW_5JtO&source=gbs_api	0	2021-12-18 23:22:17	4
//79	Mastery	Robert Greene	2012-11-19	<p><b>'Machiavelli has a new rival, and Sun-tzu had better watch his back' - <i>New York Times</i></b><br><br>Around the globe, people are facing the same problem - that we are born as individuals but are forced to conform to the rules of society if we want to succeed. To see our uniqueness expressed in our achievements, we must first learn the rules - and then how to change them completely.<br><br>Charles Darwin began as an underachieving schoolboy, Leonardo da Vinci as an illegitimate outcast. The secret of their eventual greatness lies in a 'rigorous apprenticeship': by paying close and careful attention, they learnt to master the 'hidden codes' which determine ultimate success or failure. Then, they rewrote the rules as a reflection of their own individuality, blasting previous patterns of achievement open from within.<br><br>Told through Robert Greene's signature blend of historical anecdote and psychological insight and drawing on interviews with world leaders, <i>Mastery</i> builds on the strategies outlined in <i>The</i> <i>48 Laws of Power</i> to provide a practical guide to greatness - and how to start living by your own rules.<br><br>From the internationally bestselling author of <i><b>The 48 Laws of Power</b></i>, <i><b>The Art Of Seduction</b></i>, and <i><b>The 33 Strategies Of War</b></i>.</p>	http://books.google.com/books/content?id=ObtCSg3BZBIC&printsec=frontcover&img=1&zoom=5&edge=curl&imgtk=AFLRE71XHt0OK9CzICkN6xvXFIPB92vZObeTYGlk2ck-U1Y6zJ4fxF0qFc_ivTTSSCsvE7ocKiRVh6Arp0zGHztDlHp2Yin8qsp0RtsZwpIAPr6dnYC8-zIJzr6yrJxgXDrwln8xNMZG&source=gbs_api	2	2021-12-18 23:23:24	0
//80	One Up On Wall Street	Peter Lynch, John Rothchild	2000-04-03	<b>THE NATIONAL BESTSELLING BOOK THAT EVERY INVESTOR SHOULD OWN</b> <p> Peter Lynch is America's number-one money manager. His mantra: Average investors can become experts in their own field and can pick winning stocks as effectively as Wall Street professionals by doing just a little research. <p> Now, in a new introduction written specifically for this edition of <i>One Up on Wall Street,</i> Lynch gives his take on the incredible rise of Internet stocks, as well as a list of twenty winning companies of high-tech '90s. That many of these winners are low-tech supports his thesis that amateur investors can continue to reap exceptional rewards from mundane, easy-to-understand companies they encounter in their daily lives. <p> Investment opportunities abound for the layperson, Lynch says. By simply observing business developments and taking notice of your immediate world -- from the mall to the workplace -- you can discover potentially successful companies before professional analysts do. This jump on the experts is what produces "tenbaggers," the stocks that appreciate tenfold or more and turn an average stock portfolio into a star performer. <p> The former star manager of Fidelity's multibillion-dollar Magellan Fund, Lynch reveals how he achieved his spectacular record. Writing with John Rothchild, Lynch offers easy-to-follow directions for sorting out the long shots from the no shots by reviewing a company's financial statements and by identifying which numbers <i>really</i> count. He explains how to stalk tenbaggers and lays out the guidelines for investing in cyclical, turnaround, and fast-growing companies. <p> Lynch promises that if you ignore the ups and downs of the market and the endless speculation about interest rates, in the long term (anywhere from five to fifteen years) your portfolio will reward you. This advice has proved to be timeless and has made <i>One Up on Wall Street</i> a number-one bestseller. And now this classic is as valuable in the new millennium as ever.http://books.google.com/books/content?id=KcJaXu7FVZ0C&printsec=frontcover&img=1&zoom=5&edge=curl&imgtk=AFLRE71LrwHJr337fLncjdZDqYvwffY2tF7j9UEQTCdNVpvMaoS_520ejZmbm9gwuxIXpY2ZfsCR0pXyfpNtVRr0RgSz82bfymHZVRqHJIlCFzkKC7gucRpR9lHVFf5jMKXA5VeFZlVx&source=gbs_api	0	2021-12-18 23:24:14	5
//81  Atomic Habits	James Clear	2018-10-16	<b><b>The #1</b><b><i> New York Times</i></b><b> bestseller</b>. <b>Over 3 million copies sold!</b><br><br><b><i>Tiny Changes, Remarkable Results</i></b></b><br><br>No matter your goals, <i>Atomic Habits</i> offers a proven framework for improving--every day. James Clear, one of the world's leading experts on habit formation, reveals practical strategies that will teach you exactly how to form good habits, break bad ones, and master the tiny behaviors that lead to remarkable results.<br><br>If you're having trouble changing your habits, the problem isn't you. The problem is your system. Bad habits repeat themselves again and again not because you don't want to change, but because you have the wrong system for change. You do not rise to the level of your goals. You fall to the level of your systems. Here, you'll get a proven system that can take you to new heights.<br><br>Clear is known for his ability to distill complex topics into simple behaviors that can be easily applied to daily life and work. Here, he draws on the most proven ideas from biology, psychology, and neuroscience to create an easy-to-understand guide for making good habits inevitable and bad habits impossible. Along the way, readers will be inspired and entertained with true stories from Olympic gold medalists, award-winning artists, business leaders, life-saving physicians, and star comedians who have used the science of small habits to master their craft and vault to the top of their field.<br><br>Learn how to:<br> <b>•</b> make time for new habits (even when life gets crazy);<br> <b>•</b> overcome a lack of motivation and willpower;<br> <b>•</b> design your environment to make success easier;<br> <b>•</b> get back on track when you fall off course;<br>...and much more.<br><br><i>Atomic Habits</i> will reshape the way you think about progress and success, and give you the tools and strategies you need to transform your habits--whether you are a team looking to win a championship, an organization hoping to redefine an industry, or simply an individual who wishes to quit smoking, lose weight, reduce stress, or achieve any other goal.	http://books.google.com/books/publisher/content?id=XfFvDwAAQBAJ&printsec=frontcover&img=1&zoom=5&imgtk=AFLRE72q4nrN5SOohbG8b0E_Xf4xP7sR-SkXPc0QT7WjX7J5UIGr5RUl6o2C1FpR2CtblXylFsV4RKLyVhFFHoQYyYitxXZRB-_Uz2PdcvBHiBVndMljwcGtcK6cGfun8x4hWoOkcmAi&source=gbs_api	0	2021-12-18 23:27:08	4