#
# Autogenerated by Thrift Compiler (0.9.3)
#
# DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
#

require 'thrift'
require 'common_types'


module Br
  module Gov
    module Saude
      module Esusab
        module Ras
          module Cadastrodomiciliar
            class InstituicaoPermanenciaThrift
              include ::Thrift::Struct, ::Thrift::Struct_Union
              NOMEINSTITUICAOPERMANENCIA = 1
              STOUTROSPROFISSIONAISVINCULADOS = 2
              NOMERESPONSAVELTECNICO = 3
              CNSRESPONSAVELTECNICO = 4
              CARGOINSTITUICAO = 5
              TELEFONERESPONSAVELTECNICO = 6

              FIELDS = {
                NOMEINSTITUICAOPERMANENCIA => {:type => ::Thrift::Types::STRING, :name => 'nomeInstituicaoPermanencia', :optional => true},
                STOUTROSPROFISSIONAISVINCULADOS => {:type => ::Thrift::Types::BOOL, :name => 'stOutrosProfissionaisVinculados', :optional => true},
                NOMERESPONSAVELTECNICO => {:type => ::Thrift::Types::STRING, :name => 'nomeResponsavelTecnico', :optional => true},
                CNSRESPONSAVELTECNICO => {:type => ::Thrift::Types::STRING, :name => 'cnsResponsavelTecnico', :optional => true},
                CARGOINSTITUICAO => {:type => ::Thrift::Types::STRING, :name => 'cargoInstituicao', :optional => true},
                TELEFONERESPONSAVELTECNICO => {:type => ::Thrift::Types::STRING, :name => 'telefoneResponsavelTecnico', :optional => true}
              }

              def struct_fields; FIELDS; end

              def validate
              end

              ::Thrift::Struct.generate_accessors self
            end

            class CondicaoMoradiaThrift
              include ::Thrift::Struct, ::Thrift::Struct_Union
              ABASTECIMENTOAGUA = 1
              AREAPRODUCAORURAL = 2
              DESTINOLIXO = 3
              FORMAESCOAMENTOBANHEIRO = 4
              LOCALIZACAO = 5
              MATERIALPREDOMINANTEPAREDESEXTDOMICILIO = 6
              NUCOMODOS = 7
              NUMORADORES = 8
              SITUACAOMORADIAPOSSETERRA = 9
              STDISPONIBILIDADEENERGIAELETRICA = 10
              TIPOACESSODOMICILIO = 11
              TIPODOMICILIO = 12
              AGUACONSUMODOMICILIO = 13

              FIELDS = {
                ABASTECIMENTOAGUA => {:type => ::Thrift::Types::I64, :name => 'abastecimentoAgua', :optional => true},
                AREAPRODUCAORURAL => {:type => ::Thrift::Types::I64, :name => 'areaProducaoRural', :optional => true},
                DESTINOLIXO => {:type => ::Thrift::Types::I64, :name => 'destinoLixo', :optional => true},
                FORMAESCOAMENTOBANHEIRO => {:type => ::Thrift::Types::I64, :name => 'formaEscoamentoBanheiro', :optional => true},
                LOCALIZACAO => {:type => ::Thrift::Types::I64, :name => 'localizacao', :optional => true},
                MATERIALPREDOMINANTEPAREDESEXTDOMICILIO => {:type => ::Thrift::Types::I64, :name => 'materialPredominanteParedesExtDomicilio', :optional => true},
                NUCOMODOS => {:type => ::Thrift::Types::STRING, :name => 'nuComodos', :optional => true},
                NUMORADORES => {:type => ::Thrift::Types::STRING, :name => 'nuMoradores', :optional => true},
                SITUACAOMORADIAPOSSETERRA => {:type => ::Thrift::Types::I64, :name => 'situacaoMoradiaPosseTerra', :optional => true},
                STDISPONIBILIDADEENERGIAELETRICA => {:type => ::Thrift::Types::BOOL, :name => 'stDisponibilidadeEnergiaEletrica', :optional => true},
                TIPOACESSODOMICILIO => {:type => ::Thrift::Types::I64, :name => 'tipoAcessoDomicilio', :optional => true},
                TIPODOMICILIO => {:type => ::Thrift::Types::I64, :name => 'tipoDomicilio', :optional => true},
                AGUACONSUMODOMICILIO => {:type => ::Thrift::Types::I64, :name => 'aguaConsumoDomicilio', :optional => true}
              }

              def struct_fields; FIELDS; end

              def validate
              end

              ::Thrift::Struct.generate_accessors self
            end

            class FamiliaRowThrift
              include ::Thrift::Struct, ::Thrift::Struct_Union
              DATANASCIMENTORESPONSAVEL = 1
              NUMEROCNSRESPONSAVEL = 2
              NUMEROMEMBROSFAMILIA = 3
              NUMEROPRONTUARIO = 4
              RENDAFAMILIAR = 5
              RESIDEDESDE = 6
              STMUDANCA = 7
              CPFRESPONSAVEL = 8

              FIELDS = {
                DATANASCIMENTORESPONSAVEL => {:type => ::Thrift::Types::I64, :name => 'dataNascimentoResponsavel', :optional => true},
                NUMEROCNSRESPONSAVEL => {:type => ::Thrift::Types::STRING, :name => 'numeroCnsResponsavel', :optional => true},
                NUMEROMEMBROSFAMILIA => {:type => ::Thrift::Types::I32, :name => 'numeroMembrosFamilia', :optional => true},
                NUMEROPRONTUARIO => {:type => ::Thrift::Types::STRING, :name => 'numeroProntuario', :optional => true},
                RENDAFAMILIAR => {:type => ::Thrift::Types::I64, :name => 'rendaFamiliar', :optional => true},
                RESIDEDESDE => {:type => ::Thrift::Types::I64, :name => 'resideDesde', :optional => true},
                STMUDANCA => {:type => ::Thrift::Types::BOOL, :name => 'stMudanca', :optional => true},
                CPFRESPONSAVEL => {:type => ::Thrift::Types::STRING, :name => 'cpfResponsavel', :optional => true}
              }

              def struct_fields; FIELDS; end

              def validate
              end

              ::Thrift::Struct.generate_accessors self
            end

            class CadastroDomiciliarThrift
              include ::Thrift::Struct, ::Thrift::Struct_Union
              ANIMAISNODOMICILIO = 1
              CONDICAOMORADIA = 2
              ENDERECOLOCALPERMANENCIA = 4
              FAMILIAS = 5
              FICHAATUALIZADA = 6
              QUANTOSANIMAISNODOMICILIO = 7
              STANIMAISNODOMICILIO = 8
              STATUSTERMORECUSA = 9
              TPCDSORIGEM = 10
              UUID = 11
              UUIDFICHAORIGINADORA = 12
              TIPODEIMOVEL = 13
              INSTITUICAOPERMANENCIA = 14
              HEADERTRANSPORT = 15
              LATITUDE = 16
              LONGITUDE = 17

              FIELDS = {
                ANIMAISNODOMICILIO => {:type => ::Thrift::Types::LIST, :name => 'animaisNoDomicilio', :element => {:type => ::Thrift::Types::I64}, :optional => true},
                CONDICAOMORADIA => {:type => ::Thrift::Types::STRUCT, :name => 'condicaoMoradia', :class => ::Br::Gov::Saude::Esusab::Ras::Cadastrodomiciliar::CondicaoMoradiaThrift, :optional => true},
                ENDERECOLOCALPERMANENCIA => {:type => ::Thrift::Types::STRUCT, :name => 'enderecoLocalPermanencia', :class => ::Br::Gov::Saude::Esusab::Ras::Common::EnderecoLocalPermanenciaThrift, :optional => true},
                FAMILIAS => {:type => ::Thrift::Types::LIST, :name => 'familias', :element => {:type => ::Thrift::Types::STRUCT, :class => ::Br::Gov::Saude::Esusab::Ras::Cadastrodomiciliar::FamiliaRowThrift}, :optional => true},
                FICHAATUALIZADA => {:type => ::Thrift::Types::BOOL, :name => 'fichaAtualizada', :optional => true},
                QUANTOSANIMAISNODOMICILIO => {:type => ::Thrift::Types::STRING, :name => 'quantosAnimaisNoDomicilio', :optional => true},
                STANIMAISNODOMICILIO => {:type => ::Thrift::Types::BOOL, :name => 'stAnimaisNoDomicilio', :optional => true},
                STATUSTERMORECUSA => {:type => ::Thrift::Types::BOOL, :name => 'statusTermoRecusa', :optional => true},
                TPCDSORIGEM => {:type => ::Thrift::Types::I32, :name => 'tpCdsOrigem', :optional => true},
                UUID => {:type => ::Thrift::Types::STRING, :name => 'uuid'},
                UUIDFICHAORIGINADORA => {:type => ::Thrift::Types::STRING, :name => 'uuidFichaOriginadora', :optional => true},
                TIPODEIMOVEL => {:type => ::Thrift::Types::I64, :name => 'tipoDeImovel', :optional => true},
                INSTITUICAOPERMANENCIA => {:type => ::Thrift::Types::STRUCT, :name => 'instituicaoPermanencia', :class => ::Br::Gov::Saude::Esusab::Ras::Cadastrodomiciliar::InstituicaoPermanenciaThrift, :optional => true},
                HEADERTRANSPORT => {:type => ::Thrift::Types::STRUCT, :name => 'headerTransport', :class => ::Br::Gov::Saude::Esusab::Ras::Common::UnicaLotacaoHeaderThrift, :optional => true},
                LATITUDE => {:type => ::Thrift::Types::DOUBLE, :name => 'latitude', :optional => true},
                LONGITUDE => {:type => ::Thrift::Types::DOUBLE, :name => 'longitude', :optional => true}
              }

              def struct_fields; FIELDS; end

              def validate
                raise ::Thrift::ProtocolException.new(::Thrift::ProtocolException::UNKNOWN, 'Required field uuid is unset!') unless @uuid
              end

              ::Thrift::Struct.generate_accessors self
            end

          end
        end
      end
    end
  end
end
