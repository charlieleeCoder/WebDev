export let t1: string = 'Old Comedy';
export let p1s: string[] = [
    `The most important Old Comic dramatist is Aristophanes (born in 446 BC).
    His works, with their pungent political satire and abundance of sexual and scatological innuendo, effectively define the genre today. 
    Aristophanes lampooned the most important personalities and institutions of his day, as can be seen, for example, 
    in his buffoonish portrayal of Socrates in The Clouds, and in his racy anti-war farce Lysistrata. 
    He was one of a large number of comic poets working in Athens in the late 5th century, his most important contemporary rivals being Hermippus and Eupolis.`,
    `Also known as "The Father of Comedy" and "the Prince of Ancient Comedy", Aristophanes has been said to recreate the life of ancient Athens more convincingly than any other author. 
    His powers of ridicule were feared and acknowledged by influential contemporaries; 
    Plato singled out Aristophanes' play The Clouds as slander that contributed to the trial and subsequent condemning to death of Socrates, although other satirical playwrights had also caricatured the philosopher.`,
    `The Old Comedy subsequently influenced later European writers such as Rabelais, Cervantes, Swift, and Voltaire. In particular, they copied the technique of disguising a political attack as buffoonery.`
];
export let t2: string = 'Middle Comedy';
export let p2s: string[] = [
    `The line between Old and Middle Comedy is not clearly marked chronologically, 
    Aristophanes and others of the latest writers of the Old Comedy being sometimes regarded as the earliest Middle Comic poets. 
    For ancient scholars, the term may have meant little more than "later than Aristophanes and his contemporaries, but earlier than Menander". `,
    `Middle Comedy is generally seen as differing from Old Comedy in three essential particulars: the role of the chorus was diminished to the point where it had no influence on the plot; public characters were not impersonated or personified onstage; and the objects of ridicule were general rather than personal, literary rather than political. For at least a time, mythological burlesque was popular among the Middle Comic poets. `,
    `Stock characters of all sorts also emerge: courtesans, parasites, revellers, philosophers, boastful soldiers, and especially the conceited cook with his parade of culinary science.`
];
export let t3: string = 'New Comedy';
export let p3s: string[] = [
    `New Comedy followed the death of Alexander the Great in 323 BC and lasted throughout the reign of the Macedonian rulers, ending about 260 BC. 
    It is comparable to situation comedy and comedy of manners. The three best-known playwrights belonging to this genre are Menander, Philemon, and Diphilus.`,
    `The playwrights of the New Comedy genre built on the legacy from their predecessors, but adapted it to the portrayal of everyday life, rather than of public affairs. 
    The satirical and farcical element which featured so strongly in Aristophanes' comedies was increasingly abandoned, the de-emphasis of the grotesque opening the way for greater representation of daily life and the foibles of recognisable character types.`,
    `Apart from Diphilus, the New Comedians preferred the everyday world to mythological themes, coincidences to miracles or metamorphoses; 
    and they peopled this world with a whole series of semi-realistic, if somewhat stereotypical figures, 
    who would become the stock characters of Western comedy: braggarts, the permissive father figure and the stern father (senex iratus), young lovers, parasites, kind-hearted prostitutes, and cunning servants.`
]

export interface sections {
    title: string;
    img: string;
    alttext: string;
    paragraphs: string[];
};