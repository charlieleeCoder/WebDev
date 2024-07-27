export let t1: string = 'Aeschylus';
export let p1s: string[] = [
    `Aeschylus (c. 525/524 – c. 456/455 BC) was an ancient Greek tragedian often described as the father of tragedy. 
    Academic knowledge of the genre begins with his work, and understanding of earlier Greek tragedy is largely based on inferences made from reading his surviving plays. 
    According to Aristotle, he expanded the number of characters in the theatre and allowed conflict among them. Formerly, characters interacted only with the chorus.`,
    `Only seven of Aeschylus's estimated 70 to 90 plays have survived. There is a long-standing debate regarding the authorship of one of them, 
    Prometheus Bound, with some scholars arguing that it may be the work of his son Euphorion. Fragments from other plays have survived in quotations, 
    and more continue to be discovered on Egyptian papyri. These fragments often give further insights into Aeschylus' work.`,
    `He was likely the first dramatist to present plays as a trilogy. 
    His Oresteia is the only extant ancient example. At least one of his plays was influenced by the Persians' 
    second invasion of Greece (480–479 BC). This work, The Persians, is one of very few classical Greek tragedies 
    concerned with contemporary events, and the only one extant. The significance of the war with Persia was so great to Aeschylus 
    and the Greeks that his epitaph commemorates his participation in the Greek victory at Marathon while making no mention of his success as a playwright.`
];
export let t2: string = 'Sophocles';
export let p2s: string[] = [
    `Sophocles[a] (c. 497/496 – winter 406/405 BC) was an ancient Greek tragedian, known as one of three from whom at least one play has survived in full. 
    His first plays were written later than, or contemporary with, those of Aeschylus; and earlier than, or contemporary with, those of Euripides. 
    Sophocles wrote over 120 plays, but only seven have survived in a complete form: Ajax, Antigone, Women of Trachis, Oedipus Rex, Electra, Philoctetes, and Oedipus at Colonus.`,
    `For almost fifty years, Sophocles was the most celebrated playwright in the dramatic competitions of the city-state of Athens which took place during the religious festivals 
    of the Lenaea and the Dionysia. He competed in thirty competitions, won twenty-four, and was never judged lower than second place. 
    Aeschylus won thirteen competitions, and was sometimes defeated by Sophocles; Euripides won four.`,
    `Euripides is identified with theatrical innovations that have profoundly influenced drama down to modern times, 
    especially in the representation of traditional, mythical heroes as ordinary people in extraordinary circumstances.`
];
export let t3: string = 'Euripides';
export let p3s: string[] = [
    `Euripides[a] (c. 480 – c. 406 BC) was a tragedian of classical Athens. 
    Along with Aeschylus and Sophocles, he is one of the three ancient Greek tragedians 
    for whom any plays have survived in full. Some ancient scholars attributed ninety-five plays to him, 
    but the Suda says it was ninety-two at most.`,
    `Of these, eighteen or nineteen have survived more or less complete (Rhesus is suspect). 
    There are many fragments (some substantial) of most of his other plays. More of his plays have survived intact than those of Aeschylus and Sophocles together, 
    partly because his popularity grew as theirs declined.`,
    `The most famous tragedies of Sophocles feature Oedipus and Antigone: they are generally known as the Theban plays, though each was part of a different tetralogy 
    (the other members of which are now lost). Sophocles influenced the development of drama, most importantly by adding a third actor 
    (attributed to Sophocles by Aristotle; to Aeschylus by Themistius), thereby reducing the importance of the chorus in the presentation of the plot.`
]

export interface sections {
    title: string;
    img: string;
    alttext: string;
    paragraphs: string[];
};