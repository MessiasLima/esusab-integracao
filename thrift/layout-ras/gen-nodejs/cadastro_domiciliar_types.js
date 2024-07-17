//
// Autogenerated by Thrift Compiler (0.9.3)
//
// DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
//
var thrift = require('thrift');
var Thrift = thrift.Thrift;
var Q = thrift.Q;

var common_ttypes = require('./common_types')


var ttypes = module.exports = {};
InstituicaoPermanenciaThrift = module.exports.InstituicaoPermanenciaThrift = function(args) {
  this.nomeInstituicaoPermanencia = null;
  this.stOutrosProfissionaisVinculados = null;
  this.nomeResponsavelTecnico = null;
  this.cnsResponsavelTecnico = null;
  this.cargoInstituicao = null;
  this.telefoneResponsavelTecnico = null;
  if (args) {
    if (args.nomeInstituicaoPermanencia !== undefined && args.nomeInstituicaoPermanencia !== null) {
      this.nomeInstituicaoPermanencia = args.nomeInstituicaoPermanencia;
    }
    if (args.stOutrosProfissionaisVinculados !== undefined && args.stOutrosProfissionaisVinculados !== null) {
      this.stOutrosProfissionaisVinculados = args.stOutrosProfissionaisVinculados;
    }
    if (args.nomeResponsavelTecnico !== undefined && args.nomeResponsavelTecnico !== null) {
      this.nomeResponsavelTecnico = args.nomeResponsavelTecnico;
    }
    if (args.cnsResponsavelTecnico !== undefined && args.cnsResponsavelTecnico !== null) {
      this.cnsResponsavelTecnico = args.cnsResponsavelTecnico;
    }
    if (args.cargoInstituicao !== undefined && args.cargoInstituicao !== null) {
      this.cargoInstituicao = args.cargoInstituicao;
    }
    if (args.telefoneResponsavelTecnico !== undefined && args.telefoneResponsavelTecnico !== null) {
      this.telefoneResponsavelTecnico = args.telefoneResponsavelTecnico;
    }
  }
};
InstituicaoPermanenciaThrift.prototype = {};
InstituicaoPermanenciaThrift.prototype.read = function(input) {
  input.readStructBegin();
  while (true)
  {
    var ret = input.readFieldBegin();
    var fname = ret.fname;
    var ftype = ret.ftype;
    var fid = ret.fid;
    if (ftype == Thrift.Type.STOP) {
      break;
    }
    switch (fid)
    {
      case 1:
      if (ftype == Thrift.Type.STRING) {
        this.nomeInstituicaoPermanencia = input.readString();
      } else {
        input.skip(ftype);
      }
      break;
      case 2:
      if (ftype == Thrift.Type.BOOL) {
        this.stOutrosProfissionaisVinculados = input.readBool();
      } else {
        input.skip(ftype);
      }
      break;
      case 3:
      if (ftype == Thrift.Type.STRING) {
        this.nomeResponsavelTecnico = input.readString();
      } else {
        input.skip(ftype);
      }
      break;
      case 4:
      if (ftype == Thrift.Type.STRING) {
        this.cnsResponsavelTecnico = input.readString();
      } else {
        input.skip(ftype);
      }
      break;
      case 5:
      if (ftype == Thrift.Type.STRING) {
        this.cargoInstituicao = input.readString();
      } else {
        input.skip(ftype);
      }
      break;
      case 6:
      if (ftype == Thrift.Type.STRING) {
        this.telefoneResponsavelTecnico = input.readString();
      } else {
        input.skip(ftype);
      }
      break;
      default:
        input.skip(ftype);
    }
    input.readFieldEnd();
  }
  input.readStructEnd();
  return;
};

InstituicaoPermanenciaThrift.prototype.write = function(output) {
  output.writeStructBegin('InstituicaoPermanenciaThrift');
  if (this.nomeInstituicaoPermanencia !== null && this.nomeInstituicaoPermanencia !== undefined) {
    output.writeFieldBegin('nomeInstituicaoPermanencia', Thrift.Type.STRING, 1);
    output.writeString(this.nomeInstituicaoPermanencia);
    output.writeFieldEnd();
  }
  if (this.stOutrosProfissionaisVinculados !== null && this.stOutrosProfissionaisVinculados !== undefined) {
    output.writeFieldBegin('stOutrosProfissionaisVinculados', Thrift.Type.BOOL, 2);
    output.writeBool(this.stOutrosProfissionaisVinculados);
    output.writeFieldEnd();
  }
  if (this.nomeResponsavelTecnico !== null && this.nomeResponsavelTecnico !== undefined) {
    output.writeFieldBegin('nomeResponsavelTecnico', Thrift.Type.STRING, 3);
    output.writeString(this.nomeResponsavelTecnico);
    output.writeFieldEnd();
  }
  if (this.cnsResponsavelTecnico !== null && this.cnsResponsavelTecnico !== undefined) {
    output.writeFieldBegin('cnsResponsavelTecnico', Thrift.Type.STRING, 4);
    output.writeString(this.cnsResponsavelTecnico);
    output.writeFieldEnd();
  }
  if (this.cargoInstituicao !== null && this.cargoInstituicao !== undefined) {
    output.writeFieldBegin('cargoInstituicao', Thrift.Type.STRING, 5);
    output.writeString(this.cargoInstituicao);
    output.writeFieldEnd();
  }
  if (this.telefoneResponsavelTecnico !== null && this.telefoneResponsavelTecnico !== undefined) {
    output.writeFieldBegin('telefoneResponsavelTecnico', Thrift.Type.STRING, 6);
    output.writeString(this.telefoneResponsavelTecnico);
    output.writeFieldEnd();
  }
  output.writeFieldStop();
  output.writeStructEnd();
  return;
};

CondicaoMoradiaThrift = module.exports.CondicaoMoradiaThrift = function(args) {
  this.abastecimentoAgua = null;
  this.areaProducaoRural = null;
  this.destinoLixo = null;
  this.formaEscoamentoBanheiro = null;
  this.localizacao = null;
  this.materialPredominanteParedesExtDomicilio = null;
  this.nuComodos = null;
  this.nuMoradores = null;
  this.situacaoMoradiaPosseTerra = null;
  this.stDisponibilidadeEnergiaEletrica = null;
  this.tipoAcessoDomicilio = null;
  this.tipoDomicilio = null;
  this.aguaConsumoDomicilio = null;
  if (args) {
    if (args.abastecimentoAgua !== undefined && args.abastecimentoAgua !== null) {
      this.abastecimentoAgua = args.abastecimentoAgua;
    }
    if (args.areaProducaoRural !== undefined && args.areaProducaoRural !== null) {
      this.areaProducaoRural = args.areaProducaoRural;
    }
    if (args.destinoLixo !== undefined && args.destinoLixo !== null) {
      this.destinoLixo = args.destinoLixo;
    }
    if (args.formaEscoamentoBanheiro !== undefined && args.formaEscoamentoBanheiro !== null) {
      this.formaEscoamentoBanheiro = args.formaEscoamentoBanheiro;
    }
    if (args.localizacao !== undefined && args.localizacao !== null) {
      this.localizacao = args.localizacao;
    }
    if (args.materialPredominanteParedesExtDomicilio !== undefined && args.materialPredominanteParedesExtDomicilio !== null) {
      this.materialPredominanteParedesExtDomicilio = args.materialPredominanteParedesExtDomicilio;
    }
    if (args.nuComodos !== undefined && args.nuComodos !== null) {
      this.nuComodos = args.nuComodos;
    }
    if (args.nuMoradores !== undefined && args.nuMoradores !== null) {
      this.nuMoradores = args.nuMoradores;
    }
    if (args.situacaoMoradiaPosseTerra !== undefined && args.situacaoMoradiaPosseTerra !== null) {
      this.situacaoMoradiaPosseTerra = args.situacaoMoradiaPosseTerra;
    }
    if (args.stDisponibilidadeEnergiaEletrica !== undefined && args.stDisponibilidadeEnergiaEletrica !== null) {
      this.stDisponibilidadeEnergiaEletrica = args.stDisponibilidadeEnergiaEletrica;
    }
    if (args.tipoAcessoDomicilio !== undefined && args.tipoAcessoDomicilio !== null) {
      this.tipoAcessoDomicilio = args.tipoAcessoDomicilio;
    }
    if (args.tipoDomicilio !== undefined && args.tipoDomicilio !== null) {
      this.tipoDomicilio = args.tipoDomicilio;
    }
    if (args.aguaConsumoDomicilio !== undefined && args.aguaConsumoDomicilio !== null) {
      this.aguaConsumoDomicilio = args.aguaConsumoDomicilio;
    }
  }
};
CondicaoMoradiaThrift.prototype = {};
CondicaoMoradiaThrift.prototype.read = function(input) {
  input.readStructBegin();
  while (true)
  {
    var ret = input.readFieldBegin();
    var fname = ret.fname;
    var ftype = ret.ftype;
    var fid = ret.fid;
    if (ftype == Thrift.Type.STOP) {
      break;
    }
    switch (fid)
    {
      case 1:
      if (ftype == Thrift.Type.I64) {
        this.abastecimentoAgua = input.readI64();
      } else {
        input.skip(ftype);
      }
      break;
      case 2:
      if (ftype == Thrift.Type.I64) {
        this.areaProducaoRural = input.readI64();
      } else {
        input.skip(ftype);
      }
      break;
      case 3:
      if (ftype == Thrift.Type.I64) {
        this.destinoLixo = input.readI64();
      } else {
        input.skip(ftype);
      }
      break;
      case 4:
      if (ftype == Thrift.Type.I64) {
        this.formaEscoamentoBanheiro = input.readI64();
      } else {
        input.skip(ftype);
      }
      break;
      case 5:
      if (ftype == Thrift.Type.I64) {
        this.localizacao = input.readI64();
      } else {
        input.skip(ftype);
      }
      break;
      case 6:
      if (ftype == Thrift.Type.I64) {
        this.materialPredominanteParedesExtDomicilio = input.readI64();
      } else {
        input.skip(ftype);
      }
      break;
      case 7:
      if (ftype == Thrift.Type.STRING) {
        this.nuComodos = input.readString();
      } else {
        input.skip(ftype);
      }
      break;
      case 8:
      if (ftype == Thrift.Type.STRING) {
        this.nuMoradores = input.readString();
      } else {
        input.skip(ftype);
      }
      break;
      case 9:
      if (ftype == Thrift.Type.I64) {
        this.situacaoMoradiaPosseTerra = input.readI64();
      } else {
        input.skip(ftype);
      }
      break;
      case 10:
      if (ftype == Thrift.Type.BOOL) {
        this.stDisponibilidadeEnergiaEletrica = input.readBool();
      } else {
        input.skip(ftype);
      }
      break;
      case 11:
      if (ftype == Thrift.Type.I64) {
        this.tipoAcessoDomicilio = input.readI64();
      } else {
        input.skip(ftype);
      }
      break;
      case 12:
      if (ftype == Thrift.Type.I64) {
        this.tipoDomicilio = input.readI64();
      } else {
        input.skip(ftype);
      }
      break;
      case 13:
      if (ftype == Thrift.Type.I64) {
        this.aguaConsumoDomicilio = input.readI64();
      } else {
        input.skip(ftype);
      }
      break;
      default:
        input.skip(ftype);
    }
    input.readFieldEnd();
  }
  input.readStructEnd();
  return;
};

CondicaoMoradiaThrift.prototype.write = function(output) {
  output.writeStructBegin('CondicaoMoradiaThrift');
  if (this.abastecimentoAgua !== null && this.abastecimentoAgua !== undefined) {
    output.writeFieldBegin('abastecimentoAgua', Thrift.Type.I64, 1);
    output.writeI64(this.abastecimentoAgua);
    output.writeFieldEnd();
  }
  if (this.areaProducaoRural !== null && this.areaProducaoRural !== undefined) {
    output.writeFieldBegin('areaProducaoRural', Thrift.Type.I64, 2);
    output.writeI64(this.areaProducaoRural);
    output.writeFieldEnd();
  }
  if (this.destinoLixo !== null && this.destinoLixo !== undefined) {
    output.writeFieldBegin('destinoLixo', Thrift.Type.I64, 3);
    output.writeI64(this.destinoLixo);
    output.writeFieldEnd();
  }
  if (this.formaEscoamentoBanheiro !== null && this.formaEscoamentoBanheiro !== undefined) {
    output.writeFieldBegin('formaEscoamentoBanheiro', Thrift.Type.I64, 4);
    output.writeI64(this.formaEscoamentoBanheiro);
    output.writeFieldEnd();
  }
  if (this.localizacao !== null && this.localizacao !== undefined) {
    output.writeFieldBegin('localizacao', Thrift.Type.I64, 5);
    output.writeI64(this.localizacao);
    output.writeFieldEnd();
  }
  if (this.materialPredominanteParedesExtDomicilio !== null && this.materialPredominanteParedesExtDomicilio !== undefined) {
    output.writeFieldBegin('materialPredominanteParedesExtDomicilio', Thrift.Type.I64, 6);
    output.writeI64(this.materialPredominanteParedesExtDomicilio);
    output.writeFieldEnd();
  }
  if (this.nuComodos !== null && this.nuComodos !== undefined) {
    output.writeFieldBegin('nuComodos', Thrift.Type.STRING, 7);
    output.writeString(this.nuComodos);
    output.writeFieldEnd();
  }
  if (this.nuMoradores !== null && this.nuMoradores !== undefined) {
    output.writeFieldBegin('nuMoradores', Thrift.Type.STRING, 8);
    output.writeString(this.nuMoradores);
    output.writeFieldEnd();
  }
  if (this.situacaoMoradiaPosseTerra !== null && this.situacaoMoradiaPosseTerra !== undefined) {
    output.writeFieldBegin('situacaoMoradiaPosseTerra', Thrift.Type.I64, 9);
    output.writeI64(this.situacaoMoradiaPosseTerra);
    output.writeFieldEnd();
  }
  if (this.stDisponibilidadeEnergiaEletrica !== null && this.stDisponibilidadeEnergiaEletrica !== undefined) {
    output.writeFieldBegin('stDisponibilidadeEnergiaEletrica', Thrift.Type.BOOL, 10);
    output.writeBool(this.stDisponibilidadeEnergiaEletrica);
    output.writeFieldEnd();
  }
  if (this.tipoAcessoDomicilio !== null && this.tipoAcessoDomicilio !== undefined) {
    output.writeFieldBegin('tipoAcessoDomicilio', Thrift.Type.I64, 11);
    output.writeI64(this.tipoAcessoDomicilio);
    output.writeFieldEnd();
  }
  if (this.tipoDomicilio !== null && this.tipoDomicilio !== undefined) {
    output.writeFieldBegin('tipoDomicilio', Thrift.Type.I64, 12);
    output.writeI64(this.tipoDomicilio);
    output.writeFieldEnd();
  }
  if (this.aguaConsumoDomicilio !== null && this.aguaConsumoDomicilio !== undefined) {
    output.writeFieldBegin('aguaConsumoDomicilio', Thrift.Type.I64, 13);
    output.writeI64(this.aguaConsumoDomicilio);
    output.writeFieldEnd();
  }
  output.writeFieldStop();
  output.writeStructEnd();
  return;
};

FamiliaRowThrift = module.exports.FamiliaRowThrift = function(args) {
  this.dataNascimentoResponsavel = null;
  this.numeroCnsResponsavel = null;
  this.numeroMembrosFamilia = null;
  this.numeroProntuario = null;
  this.rendaFamiliar = null;
  this.resideDesde = null;
  this.stMudanca = null;
  this.cpfResponsavel = null;
  if (args) {
    if (args.dataNascimentoResponsavel !== undefined && args.dataNascimentoResponsavel !== null) {
      this.dataNascimentoResponsavel = args.dataNascimentoResponsavel;
    }
    if (args.numeroCnsResponsavel !== undefined && args.numeroCnsResponsavel !== null) {
      this.numeroCnsResponsavel = args.numeroCnsResponsavel;
    }
    if (args.numeroMembrosFamilia !== undefined && args.numeroMembrosFamilia !== null) {
      this.numeroMembrosFamilia = args.numeroMembrosFamilia;
    }
    if (args.numeroProntuario !== undefined && args.numeroProntuario !== null) {
      this.numeroProntuario = args.numeroProntuario;
    }
    if (args.rendaFamiliar !== undefined && args.rendaFamiliar !== null) {
      this.rendaFamiliar = args.rendaFamiliar;
    }
    if (args.resideDesde !== undefined && args.resideDesde !== null) {
      this.resideDesde = args.resideDesde;
    }
    if (args.stMudanca !== undefined && args.stMudanca !== null) {
      this.stMudanca = args.stMudanca;
    }
    if (args.cpfResponsavel !== undefined && args.cpfResponsavel !== null) {
      this.cpfResponsavel = args.cpfResponsavel;
    }
  }
};
FamiliaRowThrift.prototype = {};
FamiliaRowThrift.prototype.read = function(input) {
  input.readStructBegin();
  while (true)
  {
    var ret = input.readFieldBegin();
    var fname = ret.fname;
    var ftype = ret.ftype;
    var fid = ret.fid;
    if (ftype == Thrift.Type.STOP) {
      break;
    }
    switch (fid)
    {
      case 1:
      if (ftype == Thrift.Type.I64) {
        this.dataNascimentoResponsavel = input.readI64();
      } else {
        input.skip(ftype);
      }
      break;
      case 2:
      if (ftype == Thrift.Type.STRING) {
        this.numeroCnsResponsavel = input.readString();
      } else {
        input.skip(ftype);
      }
      break;
      case 3:
      if (ftype == Thrift.Type.I32) {
        this.numeroMembrosFamilia = input.readI32();
      } else {
        input.skip(ftype);
      }
      break;
      case 4:
      if (ftype == Thrift.Type.STRING) {
        this.numeroProntuario = input.readString();
      } else {
        input.skip(ftype);
      }
      break;
      case 5:
      if (ftype == Thrift.Type.I64) {
        this.rendaFamiliar = input.readI64();
      } else {
        input.skip(ftype);
      }
      break;
      case 6:
      if (ftype == Thrift.Type.I64) {
        this.resideDesde = input.readI64();
      } else {
        input.skip(ftype);
      }
      break;
      case 7:
      if (ftype == Thrift.Type.BOOL) {
        this.stMudanca = input.readBool();
      } else {
        input.skip(ftype);
      }
      break;
      case 8:
      if (ftype == Thrift.Type.STRING) {
        this.cpfResponsavel = input.readString();
      } else {
        input.skip(ftype);
      }
      break;
      default:
        input.skip(ftype);
    }
    input.readFieldEnd();
  }
  input.readStructEnd();
  return;
};

FamiliaRowThrift.prototype.write = function(output) {
  output.writeStructBegin('FamiliaRowThrift');
  if (this.dataNascimentoResponsavel !== null && this.dataNascimentoResponsavel !== undefined) {
    output.writeFieldBegin('dataNascimentoResponsavel', Thrift.Type.I64, 1);
    output.writeI64(this.dataNascimentoResponsavel);
    output.writeFieldEnd();
  }
  if (this.numeroCnsResponsavel !== null && this.numeroCnsResponsavel !== undefined) {
    output.writeFieldBegin('numeroCnsResponsavel', Thrift.Type.STRING, 2);
    output.writeString(this.numeroCnsResponsavel);
    output.writeFieldEnd();
  }
  if (this.numeroMembrosFamilia !== null && this.numeroMembrosFamilia !== undefined) {
    output.writeFieldBegin('numeroMembrosFamilia', Thrift.Type.I32, 3);
    output.writeI32(this.numeroMembrosFamilia);
    output.writeFieldEnd();
  }
  if (this.numeroProntuario !== null && this.numeroProntuario !== undefined) {
    output.writeFieldBegin('numeroProntuario', Thrift.Type.STRING, 4);
    output.writeString(this.numeroProntuario);
    output.writeFieldEnd();
  }
  if (this.rendaFamiliar !== null && this.rendaFamiliar !== undefined) {
    output.writeFieldBegin('rendaFamiliar', Thrift.Type.I64, 5);
    output.writeI64(this.rendaFamiliar);
    output.writeFieldEnd();
  }
  if (this.resideDesde !== null && this.resideDesde !== undefined) {
    output.writeFieldBegin('resideDesde', Thrift.Type.I64, 6);
    output.writeI64(this.resideDesde);
    output.writeFieldEnd();
  }
  if (this.stMudanca !== null && this.stMudanca !== undefined) {
    output.writeFieldBegin('stMudanca', Thrift.Type.BOOL, 7);
    output.writeBool(this.stMudanca);
    output.writeFieldEnd();
  }
  if (this.cpfResponsavel !== null && this.cpfResponsavel !== undefined) {
    output.writeFieldBegin('cpfResponsavel', Thrift.Type.STRING, 8);
    output.writeString(this.cpfResponsavel);
    output.writeFieldEnd();
  }
  output.writeFieldStop();
  output.writeStructEnd();
  return;
};

CadastroDomiciliarThrift = module.exports.CadastroDomiciliarThrift = function(args) {
  this.animaisNoDomicilio = null;
  this.condicaoMoradia = null;
  this.enderecoLocalPermanencia = null;
  this.familias = null;
  this.fichaAtualizada = null;
  this.quantosAnimaisNoDomicilio = null;
  this.stAnimaisNoDomicilio = null;
  this.statusTermoRecusa = null;
  this.tpCdsOrigem = null;
  this.uuid = null;
  this.uuidFichaOriginadora = null;
  this.tipoDeImovel = null;
  this.instituicaoPermanencia = null;
  this.headerTransport = null;
  this.latitude = null;
  this.longitude = null;
  if (args) {
    if (args.animaisNoDomicilio !== undefined && args.animaisNoDomicilio !== null) {
      this.animaisNoDomicilio = Thrift.copyList(args.animaisNoDomicilio, [null]);
    }
    if (args.condicaoMoradia !== undefined && args.condicaoMoradia !== null) {
      this.condicaoMoradia = new ttypes.CondicaoMoradiaThrift(args.condicaoMoradia);
    }
    if (args.enderecoLocalPermanencia !== undefined && args.enderecoLocalPermanencia !== null) {
      this.enderecoLocalPermanencia = new common_ttypes.EnderecoLocalPermanenciaThrift(args.enderecoLocalPermanencia);
    }
    if (args.familias !== undefined && args.familias !== null) {
      this.familias = Thrift.copyList(args.familias, [ttypes.FamiliaRowThrift]);
    }
    if (args.fichaAtualizada !== undefined && args.fichaAtualizada !== null) {
      this.fichaAtualizada = args.fichaAtualizada;
    }
    if (args.quantosAnimaisNoDomicilio !== undefined && args.quantosAnimaisNoDomicilio !== null) {
      this.quantosAnimaisNoDomicilio = args.quantosAnimaisNoDomicilio;
    }
    if (args.stAnimaisNoDomicilio !== undefined && args.stAnimaisNoDomicilio !== null) {
      this.stAnimaisNoDomicilio = args.stAnimaisNoDomicilio;
    }
    if (args.statusTermoRecusa !== undefined && args.statusTermoRecusa !== null) {
      this.statusTermoRecusa = args.statusTermoRecusa;
    }
    if (args.tpCdsOrigem !== undefined && args.tpCdsOrigem !== null) {
      this.tpCdsOrigem = args.tpCdsOrigem;
    }
    if (args.uuid !== undefined && args.uuid !== null) {
      this.uuid = args.uuid;
    } else {
      throw new Thrift.TProtocolException(Thrift.TProtocolExceptionType.UNKNOWN, 'Required field uuid is unset!');
    }
    if (args.uuidFichaOriginadora !== undefined && args.uuidFichaOriginadora !== null) {
      this.uuidFichaOriginadora = args.uuidFichaOriginadora;
    }
    if (args.tipoDeImovel !== undefined && args.tipoDeImovel !== null) {
      this.tipoDeImovel = args.tipoDeImovel;
    }
    if (args.instituicaoPermanencia !== undefined && args.instituicaoPermanencia !== null) {
      this.instituicaoPermanencia = new ttypes.InstituicaoPermanenciaThrift(args.instituicaoPermanencia);
    }
    if (args.headerTransport !== undefined && args.headerTransport !== null) {
      this.headerTransport = new common_ttypes.UnicaLotacaoHeaderThrift(args.headerTransport);
    }
    if (args.latitude !== undefined && args.latitude !== null) {
      this.latitude = args.latitude;
    }
    if (args.longitude !== undefined && args.longitude !== null) {
      this.longitude = args.longitude;
    }
  }
};
CadastroDomiciliarThrift.prototype = {};
CadastroDomiciliarThrift.prototype.read = function(input) {
  input.readStructBegin();
  while (true)
  {
    var ret = input.readFieldBegin();
    var fname = ret.fname;
    var ftype = ret.ftype;
    var fid = ret.fid;
    if (ftype == Thrift.Type.STOP) {
      break;
    }
    switch (fid)
    {
      case 1:
      if (ftype == Thrift.Type.LIST) {
        var _size0 = 0;
        var _rtmp34;
        this.animaisNoDomicilio = [];
        var _etype3 = 0;
        _rtmp34 = input.readListBegin();
        _etype3 = _rtmp34.etype;
        _size0 = _rtmp34.size;
        for (var _i5 = 0; _i5 < _size0; ++_i5)
        {
          var elem6 = null;
          elem6 = input.readI64();
          this.animaisNoDomicilio.push(elem6);
        }
        input.readListEnd();
      } else {
        input.skip(ftype);
      }
      break;
      case 2:
      if (ftype == Thrift.Type.STRUCT) {
        this.condicaoMoradia = new ttypes.CondicaoMoradiaThrift();
        this.condicaoMoradia.read(input);
      } else {
        input.skip(ftype);
      }
      break;
      case 4:
      if (ftype == Thrift.Type.STRUCT) {
        this.enderecoLocalPermanencia = new common_ttypes.EnderecoLocalPermanenciaThrift();
        this.enderecoLocalPermanencia.read(input);
      } else {
        input.skip(ftype);
      }
      break;
      case 5:
      if (ftype == Thrift.Type.LIST) {
        var _size7 = 0;
        var _rtmp311;
        this.familias = [];
        var _etype10 = 0;
        _rtmp311 = input.readListBegin();
        _etype10 = _rtmp311.etype;
        _size7 = _rtmp311.size;
        for (var _i12 = 0; _i12 < _size7; ++_i12)
        {
          var elem13 = null;
          elem13 = new ttypes.FamiliaRowThrift();
          elem13.read(input);
          this.familias.push(elem13);
        }
        input.readListEnd();
      } else {
        input.skip(ftype);
      }
      break;
      case 6:
      if (ftype == Thrift.Type.BOOL) {
        this.fichaAtualizada = input.readBool();
      } else {
        input.skip(ftype);
      }
      break;
      case 7:
      if (ftype == Thrift.Type.STRING) {
        this.quantosAnimaisNoDomicilio = input.readString();
      } else {
        input.skip(ftype);
      }
      break;
      case 8:
      if (ftype == Thrift.Type.BOOL) {
        this.stAnimaisNoDomicilio = input.readBool();
      } else {
        input.skip(ftype);
      }
      break;
      case 9:
      if (ftype == Thrift.Type.BOOL) {
        this.statusTermoRecusa = input.readBool();
      } else {
        input.skip(ftype);
      }
      break;
      case 10:
      if (ftype == Thrift.Type.I32) {
        this.tpCdsOrigem = input.readI32();
      } else {
        input.skip(ftype);
      }
      break;
      case 11:
      if (ftype == Thrift.Type.STRING) {
        this.uuid = input.readString();
      } else {
        input.skip(ftype);
      }
      break;
      case 12:
      if (ftype == Thrift.Type.STRING) {
        this.uuidFichaOriginadora = input.readString();
      } else {
        input.skip(ftype);
      }
      break;
      case 13:
      if (ftype == Thrift.Type.I64) {
        this.tipoDeImovel = input.readI64();
      } else {
        input.skip(ftype);
      }
      break;
      case 14:
      if (ftype == Thrift.Type.STRUCT) {
        this.instituicaoPermanencia = new ttypes.InstituicaoPermanenciaThrift();
        this.instituicaoPermanencia.read(input);
      } else {
        input.skip(ftype);
      }
      break;
      case 15:
      if (ftype == Thrift.Type.STRUCT) {
        this.headerTransport = new common_ttypes.UnicaLotacaoHeaderThrift();
        this.headerTransport.read(input);
      } else {
        input.skip(ftype);
      }
      break;
      case 16:
      if (ftype == Thrift.Type.DOUBLE) {
        this.latitude = input.readDouble();
      } else {
        input.skip(ftype);
      }
      break;
      case 17:
      if (ftype == Thrift.Type.DOUBLE) {
        this.longitude = input.readDouble();
      } else {
        input.skip(ftype);
      }
      break;
      default:
        input.skip(ftype);
    }
    input.readFieldEnd();
  }
  input.readStructEnd();
  return;
};

CadastroDomiciliarThrift.prototype.write = function(output) {
  output.writeStructBegin('CadastroDomiciliarThrift');
  if (this.animaisNoDomicilio !== null && this.animaisNoDomicilio !== undefined) {
    output.writeFieldBegin('animaisNoDomicilio', Thrift.Type.LIST, 1);
    output.writeListBegin(Thrift.Type.I64, this.animaisNoDomicilio.length);
    for (var iter14 in this.animaisNoDomicilio)
    {
      if (this.animaisNoDomicilio.hasOwnProperty(iter14))
      {
        iter14 = this.animaisNoDomicilio[iter14];
        output.writeI64(iter14);
      }
    }
    output.writeListEnd();
    output.writeFieldEnd();
  }
  if (this.condicaoMoradia !== null && this.condicaoMoradia !== undefined) {
    output.writeFieldBegin('condicaoMoradia', Thrift.Type.STRUCT, 2);
    this.condicaoMoradia.write(output);
    output.writeFieldEnd();
  }
  if (this.enderecoLocalPermanencia !== null && this.enderecoLocalPermanencia !== undefined) {
    output.writeFieldBegin('enderecoLocalPermanencia', Thrift.Type.STRUCT, 4);
    this.enderecoLocalPermanencia.write(output);
    output.writeFieldEnd();
  }
  if (this.familias !== null && this.familias !== undefined) {
    output.writeFieldBegin('familias', Thrift.Type.LIST, 5);
    output.writeListBegin(Thrift.Type.STRUCT, this.familias.length);
    for (var iter15 in this.familias)
    {
      if (this.familias.hasOwnProperty(iter15))
      {
        iter15 = this.familias[iter15];
        iter15.write(output);
      }
    }
    output.writeListEnd();
    output.writeFieldEnd();
  }
  if (this.fichaAtualizada !== null && this.fichaAtualizada !== undefined) {
    output.writeFieldBegin('fichaAtualizada', Thrift.Type.BOOL, 6);
    output.writeBool(this.fichaAtualizada);
    output.writeFieldEnd();
  }
  if (this.quantosAnimaisNoDomicilio !== null && this.quantosAnimaisNoDomicilio !== undefined) {
    output.writeFieldBegin('quantosAnimaisNoDomicilio', Thrift.Type.STRING, 7);
    output.writeString(this.quantosAnimaisNoDomicilio);
    output.writeFieldEnd();
  }
  if (this.stAnimaisNoDomicilio !== null && this.stAnimaisNoDomicilio !== undefined) {
    output.writeFieldBegin('stAnimaisNoDomicilio', Thrift.Type.BOOL, 8);
    output.writeBool(this.stAnimaisNoDomicilio);
    output.writeFieldEnd();
  }
  if (this.statusTermoRecusa !== null && this.statusTermoRecusa !== undefined) {
    output.writeFieldBegin('statusTermoRecusa', Thrift.Type.BOOL, 9);
    output.writeBool(this.statusTermoRecusa);
    output.writeFieldEnd();
  }
  if (this.tpCdsOrigem !== null && this.tpCdsOrigem !== undefined) {
    output.writeFieldBegin('tpCdsOrigem', Thrift.Type.I32, 10);
    output.writeI32(this.tpCdsOrigem);
    output.writeFieldEnd();
  }
  if (this.uuid !== null && this.uuid !== undefined) {
    output.writeFieldBegin('uuid', Thrift.Type.STRING, 11);
    output.writeString(this.uuid);
    output.writeFieldEnd();
  }
  if (this.uuidFichaOriginadora !== null && this.uuidFichaOriginadora !== undefined) {
    output.writeFieldBegin('uuidFichaOriginadora', Thrift.Type.STRING, 12);
    output.writeString(this.uuidFichaOriginadora);
    output.writeFieldEnd();
  }
  if (this.tipoDeImovel !== null && this.tipoDeImovel !== undefined) {
    output.writeFieldBegin('tipoDeImovel', Thrift.Type.I64, 13);
    output.writeI64(this.tipoDeImovel);
    output.writeFieldEnd();
  }
  if (this.instituicaoPermanencia !== null && this.instituicaoPermanencia !== undefined) {
    output.writeFieldBegin('instituicaoPermanencia', Thrift.Type.STRUCT, 14);
    this.instituicaoPermanencia.write(output);
    output.writeFieldEnd();
  }
  if (this.headerTransport !== null && this.headerTransport !== undefined) {
    output.writeFieldBegin('headerTransport', Thrift.Type.STRUCT, 15);
    this.headerTransport.write(output);
    output.writeFieldEnd();
  }
  if (this.latitude !== null && this.latitude !== undefined) {
    output.writeFieldBegin('latitude', Thrift.Type.DOUBLE, 16);
    output.writeDouble(this.latitude);
    output.writeFieldEnd();
  }
  if (this.longitude !== null && this.longitude !== undefined) {
    output.writeFieldBegin('longitude', Thrift.Type.DOUBLE, 17);
    output.writeDouble(this.longitude);
    output.writeFieldEnd();
  }
  output.writeFieldStop();
  output.writeStructEnd();
  return;
};

