#language: pt

Funcionalidade: Calcular a Idade por Nome

Cenário: Verificar se a idade da pessoa é calculada de acordo com o nome da pessoa com sucesso
	Quando faço o calculo da idade de <nomePessoa>
	Então devo obter o status <statusCode> da API
	E devo obter a idade <idadePessoa>

Exemplos:
	| nomePessoa | idadePessoa | statusCode |
	| Barbara    | 53          | 200        |
	| Gian       | 68          | 200        |
	| Daniele    | 49          | 200        |
	| Vinicius   | 40          | 200        |
	| Andre      | 57          | 200        |
	| Patrick    | 60          | 200        |
	| Mateus     | 29          | 200        |

Cenário: Verificar se a API retorna erro quando o nome da pessoa não é informado
	Quando faço o calculo da idade de <nomePessoa>
	Então devo obter o status <statusCode> da API
	E devo obter a mensagem <mensagem>

Exemplos:
	| nomePessoa | statusCode | mensagem                 |
	|            | 422        | Missing 'name' parameter |

