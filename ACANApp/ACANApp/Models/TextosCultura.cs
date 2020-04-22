using System;
using System.Collections.Generic;
using System.Text;

namespace ACANApp.Models
{
    class TextosCultura
    {
		private string txtEspirito;
		private string txtHakama;
		private string txtKimono;
		private string txtCaligrafia;
		private string txtTienShen;
		private string txtZanshin;
		private string txtSeiza;

		public string TxtEspirito
		{
			get { return txtEspirito; }
			set { txtEspirito = value; }
		}
		public string TxtHakama
		{
			get { return txtHakama; }
			set { txtHakama = value; }
		}
		public string MyProperty
		{
			get { return txtKimono; }
			set { txtKimono = value; }
		}
		public string TxtCaligrafia
		{
			get { return txtCaligrafia; }
			set { txtCaligrafia = value; }
		}
		public string TienShen
		{
			get { return txtTienShen; }
			set { txtTienShen = value; }
		}
		public string TxtZanshin
		{
			get { return txtZanshin; }
			set { txtZanshin = value; }
		}
		public string TxtSeiza
		{
			get { return txtSeiza; }
			set { txtSeiza = value; }
		}

		public TextosCultura()
		{
			DefinicaoTextoEspirito();
			DefinicaoTextoHakama();
			DefinicaoTextoKimono();
			DefinicaoTextoCaligrafia();
			DefinicaoTextoTienShen();
			DefinicaoTextoZanshin();
			DefinicaoTextoSeiza();
		}

		public void DefinicaoTextoEspirito()
		{
			txtEspirito =
				"\t\tO Aikidô foi desenvolvido no Japão e portanto está profundamente " +
				"enraizado nos princípios do modo de ser japonês.\n\t\tOs valores morais, " +
				"obediência à hierarquia e observação às regras de cortesia, pontuam e " +
				"servem de pilares no desenvolvimento da arte. Difundido pelo mundo e " +
				"passados muitos anos desde o surgimento, o Aikidô preserva os preceitos " +
				"do seu fundador.\n\t\tOs ensinamentos procuram desenvolver o ser humano " +
				"de forma integral, identificando o homem com o universo. O Aikidô nos é " +
				"apresentado como uma epifania profunda e maravilhosa, e não mero sistema " +
				"de empurrões, bloqueios e imobilizações. Sem a compreensão da essência, " +
				"as técnicas jamais ganharam vida.\n\t\tA prática abrange um aspecto mais " +
				"amplo da vida, um meio de conviver com a sociedade e de se relacionar " +
				"com a natureza em harmonia com o próprio corpo e com o universo.";
		}
		public void DefinicaoTextoHakama()
		{
			txtHakama =
				"\t\tHakama é uma peça tradicional do vestuário samurai. Usado sobre kimono " +
				"branco, comum em outras artes marciais, seu uso é parte da tradição de " +
				"muitas escolas de aikido. Existem diferentes estilos de hakama. O tipo usado " +
				"hoje em dia pelos artistas marciais com \"pernas\" é chamado joba hakama. Em " +
				"muitas escolas somente os faixas-pretas usam hakama, enquanto que em outras, " +
				"todos os praticantes usam. Em algumas academias, as mulheres já podem começar " +
				"sua prática usando hakama, mais cedo que os homens, sendo o pudor feminino a " +
				"explicação geralmente dada para esta situação. Aikido, criado como arte marcial " +
				"do pós-guerra, encontrou um Japão devastado. Sua população economicamente " +
				"fragilizada, encontrada dificuldades até para se vestir. Alguns dos alunos não " +
				"tinham condições de comprar uma vestimenta completa para prática do aikido. Em " +
				"contrapartida, haviam lutadores de renome que se vestiam com suntuosos hakama. " +
				"Numa tentativa de abrandar este tipo de diferença entre seus alunos, O'Sensei " +
				"instituiu um tipo padrão de hakama. As sete pregas do hakama (cinco na frente e " +
				"duas atrás) têm o seguinte significado simbólico:\n\n1. (Yuuki) Coragem\n2. (Jin) " +
				"Benevolência\n3. (Gi) Retidão\n4. (Rei) Cortesia\n5. (Makoto) Sinceridade\n6. " +
				"(Chuugi) Lealdade\n7. (Meiyo) Honra";
		}
		public void DefinicaoTextoKimono()
		{
			txtKimono =
				"\t\tO kimono que, literalmente, quer dizer \"veste\", é a tradicional vestimenta " +
				"japonesa para homens e mulheres. Consiste numa ampla túnica de mangas compridas, " +
				"cobrindo tudo, exceto os pés e apertada à cintura por uma tira de pano chamada " +
				"\"shita - gime\". Sobre ela vai o obi, ou cinto de damasco. O Nuihaku é o tipo " +
				"de kimono usado pelos artistas que fazem as partes femininas no teatro Nô. Desde " +
				"o começo, as mulheres, por motivo de ordem moral, não podiam subir ao palco e " +
				"atores homens faziam todos os papéis, tanto femininos quanto masculinos. Em suas " +
				"várias personificações, usavam tipos particulares de máscaras e de costumes. " +
				"Nuihaku eram roupas feitas especialmente para mulheres, em tecido decorado de " +
				"maneira preciosa ou bordado em folhas, com fios de ouro entre tecidos ou " +
				"superimpostos (Nuihaku significa ao pé da letra \"superimposto\"). O desenho se " +
				"compunha, em geral, de motivos florais. O exemplo reproduzido é feito de grandes " +
				"retângulos vermelhos e brancos. A decoração inclui plantas, festões e pequenas " +
				"pontes. Foi bordado em seda e fios de ouro, e traz o poético nome de \"flores e " +
				"plantas das quatro estações\".";
		}
		public void DefinicaoTextoCaligrafia()
		{
			txtCaligrafia =
				"\t\tPara a maioria dos ocidentais, caligrafia nada mais significa do que, " +
				"literalmente, escrita bonita. É usada em diplomas, cartões de felicitações, " +
				"convites de aniversários e casamentos,. Para orientais, a caligrafia é uma " +
				"arte como a pintura, apreciada como representação tanto pictórica como " +
				"ideográfica. A estética chinesa, com efeito, curiosamente exclui a escultura " +
				"da lista das belas-artes, considerando-a trabalho manual. Mas dá grande " +
				"importância à caligrafia. Fusão de uma ideia e de uma imagem, a caligrafia " +
				"leva em seu bojô não só conotações de signos legíveis, mas também um sentido. " +
				"Deriva do tipo de escrita definido no último período Ham (25-220 d.C.) e " +
				"sofreu alterações em várias regiões e épocas. Passou de simples invenção " +
				"estilística da dinastia Shang-Yin (1766-1122 a.C.) para os elegantes floreios " +
				"da dinastia Yuan (1280-1368). Dentre suas variedades, contam-se o k'ai shu," +
				" ou estilo da \"escrita regular\", ou hsing shu, ou estilo da \"escrita fluida\", " +
				"o ts'au shu, o estilo da \"escrita relva\". Os interessantes ritmos criados " +
				"entre o sólido das tintas e os espaços vazios do fundo, são, realmente arte em " +
				"branco e preto, um ritmo de forma e espaço.";
		}
		public void DefinicaoTextoTienShen()
		{
			txtTienShen =
				"\t\tPinturas de bambus eram particularmente estimadas pela escola intelectual " +
				"chamada \"da pintura de poeta\". Isto é fácil compreender se se lembra que a " +
				"pintura chinesa derivou da escrita e da caligrafia, representações gráficas " +
				"de idéias e coisas. Diz-se muitas vezes que o bambu, flexível e robusto, " +
				"simboliza o homem curvando-se e endireitando-se sob os golpes da adversidade. " +
				"Mas, talvez, seria bom lembrar, também, o quanto essas formas vegetais, e suas " +
				"hastes delgadas e elegantes, de folhas pequenas, e constantemente se agitando, " +
				"se prestam às pinceladas rápidas da caligrafia. Daí, talvez, o favor do motivo, " +
				"sempre presente junto aos pintores, poetas e calígrafos.";
		}
		public void DefinicaoTextoZanshin()
		{
			txtZanshin =
				"\t\tZanshin é o espírito que fica, que permanece sem se apegar, o esírito que está " +
				"sempre vigilante. O Zanshin se aplica a todos os atos da vida. A beleza natural " +
				"do corpo é o reflexo do treinamento do espírito na concentração dos gestos. O " +
				"trabalho manual, agricultura de arte ou de artesanato, não condiciona apenas a " +
				"saúde do corpo e a habilidade das mãos, mas também a agilidade do cérebro. " +
				"Através do exercício, os gestos tornam-se naturais e controlados e o corpo " +
				"encontra sua beleza. A ação natural é inconsciente e perfeitamente bela.";
		}
		public void DefinicaoTextoSeiza()
		{
			txtSeiza =
			"O verdadeiro Zen é praticado sem motivação, sem finalidade, sem mesmo procurar " +
			"o despertar. Não é preciso ir ao Japão para encontrar o autêntico ensinamento " +
			"do Zen. O verdadeiro Zen é aqui e agora, no nosso corpo, no nosso espírito. Se " +
			"a postura e a respiração são adequadas, o espírito reencontra a sua condição " +
			"natural. Não há nada para ser obtido. Nada para acontecer. Não procurar a " +
			"verdade, não fugir à ilusão. Simplesmente estar presente. Aí, então, aparece " +
			"a consciência profunda e pura, universal e ilimitada.";
		}


	}
}
