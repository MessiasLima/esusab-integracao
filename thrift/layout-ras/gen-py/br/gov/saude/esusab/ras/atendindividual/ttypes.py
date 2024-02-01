#
# Autogenerated by Thrift Compiler (0.9.3)
#
# DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
#
#  options string: py
#

from thrift.Thrift import TType, TMessageType, TException, TApplicationException
import br.gov.saude.esusab.ras.common.ttypes


from thrift.transport import TTransport
from thrift.protocol import TBinaryProtocol, TProtocol
try:
  from thrift.protocol import fastbinary
except:
  fastbinary = None



class ExameThrift:
  """
  Attributes:
   - codigoExame
   - solicitadoAvaliado
  """

  thrift_spec = (
    None, # 0
    (1, TType.STRING, 'codigoExame', None, None, ), # 1
    (2, TType.LIST, 'solicitadoAvaliado', (TType.STRING,None), None, ), # 2
  )

  def __init__(self, codigoExame=None, solicitadoAvaliado=None,):
    self.codigoExame = codigoExame
    self.solicitadoAvaliado = solicitadoAvaliado

  def read(self, iprot):
    if iprot.__class__ == TBinaryProtocol.TBinaryProtocolAccelerated and isinstance(iprot.trans, TTransport.CReadableTransport) and self.thrift_spec is not None and fastbinary is not None:
      fastbinary.decode_binary(self, iprot.trans, (self.__class__, self.thrift_spec))
      return
    iprot.readStructBegin()
    while True:
      (fname, ftype, fid) = iprot.readFieldBegin()
      if ftype == TType.STOP:
        break
      if fid == 1:
        if ftype == TType.STRING:
          self.codigoExame = iprot.readString()
        else:
          iprot.skip(ftype)
      elif fid == 2:
        if ftype == TType.LIST:
          self.solicitadoAvaliado = []
          (_etype3, _size0) = iprot.readListBegin()
          for _i4 in xrange(_size0):
            _elem5 = iprot.readString()
            self.solicitadoAvaliado.append(_elem5)
          iprot.readListEnd()
        else:
          iprot.skip(ftype)
      else:
        iprot.skip(ftype)
      iprot.readFieldEnd()
    iprot.readStructEnd()

  def write(self, oprot):
    if oprot.__class__ == TBinaryProtocol.TBinaryProtocolAccelerated and self.thrift_spec is not None and fastbinary is not None:
      oprot.trans.write(fastbinary.encode_binary(self, (self.__class__, self.thrift_spec)))
      return
    oprot.writeStructBegin('ExameThrift')
    if self.codigoExame is not None:
      oprot.writeFieldBegin('codigoExame', TType.STRING, 1)
      oprot.writeString(self.codigoExame)
      oprot.writeFieldEnd()
    if self.solicitadoAvaliado is not None:
      oprot.writeFieldBegin('solicitadoAvaliado', TType.LIST, 2)
      oprot.writeListBegin(TType.STRING, len(self.solicitadoAvaliado))
      for iter6 in self.solicitadoAvaliado:
        oprot.writeString(iter6)
      oprot.writeListEnd()
      oprot.writeFieldEnd()
    oprot.writeFieldStop()
    oprot.writeStructEnd()

  def validate(self):
    return


  def __hash__(self):
    value = 17
    value = (value * 31) ^ hash(self.codigoExame)
    value = (value * 31) ^ hash(self.solicitadoAvaliado)
    return value

  def __repr__(self):
    L = ['%s=%r' % (key, value)
      for key, value in self.__dict__.iteritems()]
    return '%s(%s)' % (self.__class__.__name__, ', '.join(L))

  def __eq__(self, other):
    return isinstance(other, self.__class__) and self.__dict__ == other.__dict__

  def __ne__(self, other):
    return not (self == other)

class ProblemaCondicaoAvaliacaoAIThrift:
  """
  Attributes:
   - ciaps
   - outroCiap1
   - outroCiap2
   - cid10
   - cid10_2
  """

  thrift_spec = (
    None, # 0
    (1, TType.LIST, 'ciaps', (TType.STRING,None), None, ), # 1
    (2, TType.STRING, 'outroCiap1', None, None, ), # 2
    (3, TType.STRING, 'outroCiap2', None, None, ), # 3
    (4, TType.STRING, 'cid10', None, None, ), # 4
    (5, TType.STRING, 'cid10_2', None, None, ), # 5
  )

  def __init__(self, ciaps=None, outroCiap1=None, outroCiap2=None, cid10=None, cid10_2=None,):
    self.ciaps = ciaps
    self.outroCiap1 = outroCiap1
    self.outroCiap2 = outroCiap2
    self.cid10 = cid10
    self.cid10_2 = cid10_2

  def read(self, iprot):
    if iprot.__class__ == TBinaryProtocol.TBinaryProtocolAccelerated and isinstance(iprot.trans, TTransport.CReadableTransport) and self.thrift_spec is not None and fastbinary is not None:
      fastbinary.decode_binary(self, iprot.trans, (self.__class__, self.thrift_spec))
      return
    iprot.readStructBegin()
    while True:
      (fname, ftype, fid) = iprot.readFieldBegin()
      if ftype == TType.STOP:
        break
      if fid == 1:
        if ftype == TType.LIST:
          self.ciaps = []
          (_etype10, _size7) = iprot.readListBegin()
          for _i11 in xrange(_size7):
            _elem12 = iprot.readString()
            self.ciaps.append(_elem12)
          iprot.readListEnd()
        else:
          iprot.skip(ftype)
      elif fid == 2:
        if ftype == TType.STRING:
          self.outroCiap1 = iprot.readString()
        else:
          iprot.skip(ftype)
      elif fid == 3:
        if ftype == TType.STRING:
          self.outroCiap2 = iprot.readString()
        else:
          iprot.skip(ftype)
      elif fid == 4:
        if ftype == TType.STRING:
          self.cid10 = iprot.readString()
        else:
          iprot.skip(ftype)
      elif fid == 5:
        if ftype == TType.STRING:
          self.cid10_2 = iprot.readString()
        else:
          iprot.skip(ftype)
      else:
        iprot.skip(ftype)
      iprot.readFieldEnd()
    iprot.readStructEnd()

  def write(self, oprot):
    if oprot.__class__ == TBinaryProtocol.TBinaryProtocolAccelerated and self.thrift_spec is not None and fastbinary is not None:
      oprot.trans.write(fastbinary.encode_binary(self, (self.__class__, self.thrift_spec)))
      return
    oprot.writeStructBegin('ProblemaCondicaoAvaliacaoAIThrift')
    if self.ciaps is not None:
      oprot.writeFieldBegin('ciaps', TType.LIST, 1)
      oprot.writeListBegin(TType.STRING, len(self.ciaps))
      for iter13 in self.ciaps:
        oprot.writeString(iter13)
      oprot.writeListEnd()
      oprot.writeFieldEnd()
    if self.outroCiap1 is not None:
      oprot.writeFieldBegin('outroCiap1', TType.STRING, 2)
      oprot.writeString(self.outroCiap1)
      oprot.writeFieldEnd()
    if self.outroCiap2 is not None:
      oprot.writeFieldBegin('outroCiap2', TType.STRING, 3)
      oprot.writeString(self.outroCiap2)
      oprot.writeFieldEnd()
    if self.cid10 is not None:
      oprot.writeFieldBegin('cid10', TType.STRING, 4)
      oprot.writeString(self.cid10)
      oprot.writeFieldEnd()
    if self.cid10_2 is not None:
      oprot.writeFieldBegin('cid10_2', TType.STRING, 5)
      oprot.writeString(self.cid10_2)
      oprot.writeFieldEnd()
    oprot.writeFieldStop()
    oprot.writeStructEnd()

  def validate(self):
    return


  def __hash__(self):
    value = 17
    value = (value * 31) ^ hash(self.ciaps)
    value = (value * 31) ^ hash(self.outroCiap1)
    value = (value * 31) ^ hash(self.outroCiap2)
    value = (value * 31) ^ hash(self.cid10)
    value = (value * 31) ^ hash(self.cid10_2)
    return value

  def __repr__(self):
    L = ['%s=%r' % (key, value)
      for key, value in self.__dict__.iteritems()]
    return '%s(%s)' % (self.__class__.__name__, ', '.join(L))

  def __eq__(self, other):
    return isinstance(other, self.__class__) and self.__dict__ == other.__dict__

  def __ne__(self, other):
    return not (self == other)

class FichaAtendimentoIndividualChildThrift:
  """
  Attributes:
   - numeroProntuario
   - cns
   - dataNascimento
   - localDeAtendimento
   - sexo
   - turno
   - tipoAtendimento
   - pesoAcompanhamentoNutricional
   - alturaAcompanhamentoNutricional
   - aleitamentoMaterno
   - dumDaGestante
   - idadeGestacional
   - atencaoDomiciliarModalidade
   - problemaCondicaoAvaliada
   - exame
   - vacinaEmDia
   - pic
   - ficouEmObservacao
   - nasfs
   - condutas
   - stGravidezPlanejada
   - nuGestasPrevias
   - nuPartos
   - racionalidadeSaude
   - perimetroCefalico
   - dataHoraInicialAtendimento
   - dataHoraFinalAtendimento
   - cpfCidadao
   - medicamentos
   - encaminhamentos
   - resultadosExames
   - uuidRnds
   - finalizadorObservacao
   - tipoParticipacaoCidadao
   - tipoParticipacaoProfissionalConvidado
  """

  thrift_spec = (
    None, # 0
    (1, TType.STRING, 'numeroProntuario', None, None, ), # 1
    (2, TType.STRING, 'cns', None, None, ), # 2
    (3, TType.I64, 'dataNascimento', None, None, ), # 3
    (4, TType.I64, 'localDeAtendimento', None, None, ), # 4
    (5, TType.I64, 'sexo', None, None, ), # 5
    (6, TType.I64, 'turno', None, None, ), # 6
    (7, TType.I64, 'tipoAtendimento', None, None, ), # 7
    (8, TType.DOUBLE, 'pesoAcompanhamentoNutricional', None, None, ), # 8
    (9, TType.DOUBLE, 'alturaAcompanhamentoNutricional', None, None, ), # 9
    (10, TType.I64, 'aleitamentoMaterno', None, None, ), # 10
    (11, TType.I64, 'dumDaGestante', None, None, ), # 11
    (12, TType.I32, 'idadeGestacional', None, None, ), # 12
    (13, TType.I64, 'atencaoDomiciliarModalidade', None, None, ), # 13
    (14, TType.STRUCT, 'problemaCondicaoAvaliada', (ProblemaCondicaoAvaliacaoAIThrift, ProblemaCondicaoAvaliacaoAIThrift.thrift_spec), None, ), # 14
    None, # 15
    None, # 16
    (17, TType.LIST, 'exame', (TType.STRUCT,(ExameThrift, ExameThrift.thrift_spec)), None, ), # 17
    (18, TType.BOOL, 'vacinaEmDia', None, None, ), # 18
    (19, TType.I64, 'pic', None, None, ), # 19
    (20, TType.BOOL, 'ficouEmObservacao', None, None, ), # 20
    (21, TType.LIST, 'nasfs', (TType.I64,None), None, ), # 21
    (22, TType.LIST, 'condutas', (TType.I64,None), None, ), # 22
    (23, TType.BOOL, 'stGravidezPlanejada', None, None, ), # 23
    (24, TType.I32, 'nuGestasPrevias', None, None, ), # 24
    (25, TType.I32, 'nuPartos', None, None, ), # 25
    (26, TType.I64, 'racionalidadeSaude', None, None, ), # 26
    (27, TType.DOUBLE, 'perimetroCefalico', None, None, ), # 27
    (28, TType.I64, 'dataHoraInicialAtendimento', None, None, ), # 28
    (29, TType.I64, 'dataHoraFinalAtendimento', None, None, ), # 29
    (30, TType.STRING, 'cpfCidadao', None, None, ), # 30
    (31, TType.LIST, 'medicamentos', (TType.STRUCT,(br.gov.saude.esusab.ras.common.ttypes.MedicamentoThrift, br.gov.saude.esusab.ras.common.ttypes.MedicamentoThrift.thrift_spec)), None, ), # 31
    (32, TType.LIST, 'encaminhamentos', (TType.STRUCT,(br.gov.saude.esusab.ras.common.ttypes.EncaminhamentoExternoThrift, br.gov.saude.esusab.ras.common.ttypes.EncaminhamentoExternoThrift.thrift_spec)), None, ), # 32
    (33, TType.LIST, 'resultadosExames', (TType.STRUCT,(br.gov.saude.esusab.ras.common.ttypes.ResultadosExameThrift, br.gov.saude.esusab.ras.common.ttypes.ResultadosExameThrift.thrift_spec)), None, ), # 33
    (34, TType.STRING, 'uuidRnds', None, None, ), # 34
    (35, TType.STRUCT, 'finalizadorObservacao', (br.gov.saude.esusab.ras.common.ttypes.LotacaoHeaderThrift, br.gov.saude.esusab.ras.common.ttypes.LotacaoHeaderThrift.thrift_spec), None, ), # 35
    (36, TType.I64, 'tipoParticipacaoCidadao', None, None, ), # 36
    (37, TType.I64, 'tipoParticipacaoProfissionalConvidado', None, None, ), # 37
  )

  def __init__(self, numeroProntuario=None, cns=None, dataNascimento=None, localDeAtendimento=None, sexo=None, turno=None, tipoAtendimento=None, pesoAcompanhamentoNutricional=None, alturaAcompanhamentoNutricional=None, aleitamentoMaterno=None, dumDaGestante=None, idadeGestacional=None, atencaoDomiciliarModalidade=None, problemaCondicaoAvaliada=None, exame=None, vacinaEmDia=None, pic=None, ficouEmObservacao=None, nasfs=None, condutas=None, stGravidezPlanejada=None, nuGestasPrevias=None, nuPartos=None, racionalidadeSaude=None, perimetroCefalico=None, dataHoraInicialAtendimento=None, dataHoraFinalAtendimento=None, cpfCidadao=None, medicamentos=None, encaminhamentos=None, resultadosExames=None, uuidRnds=None, finalizadorObservacao=None, tipoParticipacaoCidadao=None, tipoParticipacaoProfissionalConvidado=None,):
    self.numeroProntuario = numeroProntuario
    self.cns = cns
    self.dataNascimento = dataNascimento
    self.localDeAtendimento = localDeAtendimento
    self.sexo = sexo
    self.turno = turno
    self.tipoAtendimento = tipoAtendimento
    self.pesoAcompanhamentoNutricional = pesoAcompanhamentoNutricional
    self.alturaAcompanhamentoNutricional = alturaAcompanhamentoNutricional
    self.aleitamentoMaterno = aleitamentoMaterno
    self.dumDaGestante = dumDaGestante
    self.idadeGestacional = idadeGestacional
    self.atencaoDomiciliarModalidade = atencaoDomiciliarModalidade
    self.problemaCondicaoAvaliada = problemaCondicaoAvaliada
    self.exame = exame
    self.vacinaEmDia = vacinaEmDia
    self.pic = pic
    self.ficouEmObservacao = ficouEmObservacao
    self.nasfs = nasfs
    self.condutas = condutas
    self.stGravidezPlanejada = stGravidezPlanejada
    self.nuGestasPrevias = nuGestasPrevias
    self.nuPartos = nuPartos
    self.racionalidadeSaude = racionalidadeSaude
    self.perimetroCefalico = perimetroCefalico
    self.dataHoraInicialAtendimento = dataHoraInicialAtendimento
    self.dataHoraFinalAtendimento = dataHoraFinalAtendimento
    self.cpfCidadao = cpfCidadao
    self.medicamentos = medicamentos
    self.encaminhamentos = encaminhamentos
    self.resultadosExames = resultadosExames
    self.uuidRnds = uuidRnds
    self.finalizadorObservacao = finalizadorObservacao
    self.tipoParticipacaoCidadao = tipoParticipacaoCidadao
    self.tipoParticipacaoProfissionalConvidado = tipoParticipacaoProfissionalConvidado

  def read(self, iprot):
    if iprot.__class__ == TBinaryProtocol.TBinaryProtocolAccelerated and isinstance(iprot.trans, TTransport.CReadableTransport) and self.thrift_spec is not None and fastbinary is not None:
      fastbinary.decode_binary(self, iprot.trans, (self.__class__, self.thrift_spec))
      return
    iprot.readStructBegin()
    while True:
      (fname, ftype, fid) = iprot.readFieldBegin()
      if ftype == TType.STOP:
        break
      if fid == 1:
        if ftype == TType.STRING:
          self.numeroProntuario = iprot.readString()
        else:
          iprot.skip(ftype)
      elif fid == 2:
        if ftype == TType.STRING:
          self.cns = iprot.readString()
        else:
          iprot.skip(ftype)
      elif fid == 3:
        if ftype == TType.I64:
          self.dataNascimento = iprot.readI64()
        else:
          iprot.skip(ftype)
      elif fid == 4:
        if ftype == TType.I64:
          self.localDeAtendimento = iprot.readI64()
        else:
          iprot.skip(ftype)
      elif fid == 5:
        if ftype == TType.I64:
          self.sexo = iprot.readI64()
        else:
          iprot.skip(ftype)
      elif fid == 6:
        if ftype == TType.I64:
          self.turno = iprot.readI64()
        else:
          iprot.skip(ftype)
      elif fid == 7:
        if ftype == TType.I64:
          self.tipoAtendimento = iprot.readI64()
        else:
          iprot.skip(ftype)
      elif fid == 8:
        if ftype == TType.DOUBLE:
          self.pesoAcompanhamentoNutricional = iprot.readDouble()
        else:
          iprot.skip(ftype)
      elif fid == 9:
        if ftype == TType.DOUBLE:
          self.alturaAcompanhamentoNutricional = iprot.readDouble()
        else:
          iprot.skip(ftype)
      elif fid == 10:
        if ftype == TType.I64:
          self.aleitamentoMaterno = iprot.readI64()
        else:
          iprot.skip(ftype)
      elif fid == 11:
        if ftype == TType.I64:
          self.dumDaGestante = iprot.readI64()
        else:
          iprot.skip(ftype)
      elif fid == 12:
        if ftype == TType.I32:
          self.idadeGestacional = iprot.readI32()
        else:
          iprot.skip(ftype)
      elif fid == 13:
        if ftype == TType.I64:
          self.atencaoDomiciliarModalidade = iprot.readI64()
        else:
          iprot.skip(ftype)
      elif fid == 14:
        if ftype == TType.STRUCT:
          self.problemaCondicaoAvaliada = ProblemaCondicaoAvaliacaoAIThrift()
          self.problemaCondicaoAvaliada.read(iprot)
        else:
          iprot.skip(ftype)
      elif fid == 17:
        if ftype == TType.LIST:
          self.exame = []
          (_etype17, _size14) = iprot.readListBegin()
          for _i18 in xrange(_size14):
            _elem19 = ExameThrift()
            _elem19.read(iprot)
            self.exame.append(_elem19)
          iprot.readListEnd()
        else:
          iprot.skip(ftype)
      elif fid == 18:
        if ftype == TType.BOOL:
          self.vacinaEmDia = iprot.readBool()
        else:
          iprot.skip(ftype)
      elif fid == 19:
        if ftype == TType.I64:
          self.pic = iprot.readI64()
        else:
          iprot.skip(ftype)
      elif fid == 20:
        if ftype == TType.BOOL:
          self.ficouEmObservacao = iprot.readBool()
        else:
          iprot.skip(ftype)
      elif fid == 21:
        if ftype == TType.LIST:
          self.nasfs = []
          (_etype23, _size20) = iprot.readListBegin()
          for _i24 in xrange(_size20):
            _elem25 = iprot.readI64()
            self.nasfs.append(_elem25)
          iprot.readListEnd()
        else:
          iprot.skip(ftype)
      elif fid == 22:
        if ftype == TType.LIST:
          self.condutas = []
          (_etype29, _size26) = iprot.readListBegin()
          for _i30 in xrange(_size26):
            _elem31 = iprot.readI64()
            self.condutas.append(_elem31)
          iprot.readListEnd()
        else:
          iprot.skip(ftype)
      elif fid == 23:
        if ftype == TType.BOOL:
          self.stGravidezPlanejada = iprot.readBool()
        else:
          iprot.skip(ftype)
      elif fid == 24:
        if ftype == TType.I32:
          self.nuGestasPrevias = iprot.readI32()
        else:
          iprot.skip(ftype)
      elif fid == 25:
        if ftype == TType.I32:
          self.nuPartos = iprot.readI32()
        else:
          iprot.skip(ftype)
      elif fid == 26:
        if ftype == TType.I64:
          self.racionalidadeSaude = iprot.readI64()
        else:
          iprot.skip(ftype)
      elif fid == 27:
        if ftype == TType.DOUBLE:
          self.perimetroCefalico = iprot.readDouble()
        else:
          iprot.skip(ftype)
      elif fid == 28:
        if ftype == TType.I64:
          self.dataHoraInicialAtendimento = iprot.readI64()
        else:
          iprot.skip(ftype)
      elif fid == 29:
        if ftype == TType.I64:
          self.dataHoraFinalAtendimento = iprot.readI64()
        else:
          iprot.skip(ftype)
      elif fid == 30:
        if ftype == TType.STRING:
          self.cpfCidadao = iprot.readString()
        else:
          iprot.skip(ftype)
      elif fid == 31:
        if ftype == TType.LIST:
          self.medicamentos = []
          (_etype35, _size32) = iprot.readListBegin()
          for _i36 in xrange(_size32):
            _elem37 = br.gov.saude.esusab.ras.common.ttypes.MedicamentoThrift()
            _elem37.read(iprot)
            self.medicamentos.append(_elem37)
          iprot.readListEnd()
        else:
          iprot.skip(ftype)
      elif fid == 32:
        if ftype == TType.LIST:
          self.encaminhamentos = []
          (_etype41, _size38) = iprot.readListBegin()
          for _i42 in xrange(_size38):
            _elem43 = br.gov.saude.esusab.ras.common.ttypes.EncaminhamentoExternoThrift()
            _elem43.read(iprot)
            self.encaminhamentos.append(_elem43)
          iprot.readListEnd()
        else:
          iprot.skip(ftype)
      elif fid == 33:
        if ftype == TType.LIST:
          self.resultadosExames = []
          (_etype47, _size44) = iprot.readListBegin()
          for _i48 in xrange(_size44):
            _elem49 = br.gov.saude.esusab.ras.common.ttypes.ResultadosExameThrift()
            _elem49.read(iprot)
            self.resultadosExames.append(_elem49)
          iprot.readListEnd()
        else:
          iprot.skip(ftype)
      elif fid == 34:
        if ftype == TType.STRING:
          self.uuidRnds = iprot.readString()
        else:
          iprot.skip(ftype)
      elif fid == 35:
        if ftype == TType.STRUCT:
          self.finalizadorObservacao = br.gov.saude.esusab.ras.common.ttypes.LotacaoHeaderThrift()
          self.finalizadorObservacao.read(iprot)
        else:
          iprot.skip(ftype)
      elif fid == 36:
        if ftype == TType.I64:
          self.tipoParticipacaoCidadao = iprot.readI64()
        else:
          iprot.skip(ftype)
      elif fid == 37:
        if ftype == TType.I64:
          self.tipoParticipacaoProfissionalConvidado = iprot.readI64()
        else:
          iprot.skip(ftype)
      else:
        iprot.skip(ftype)
      iprot.readFieldEnd()
    iprot.readStructEnd()

  def write(self, oprot):
    if oprot.__class__ == TBinaryProtocol.TBinaryProtocolAccelerated and self.thrift_spec is not None and fastbinary is not None:
      oprot.trans.write(fastbinary.encode_binary(self, (self.__class__, self.thrift_spec)))
      return
    oprot.writeStructBegin('FichaAtendimentoIndividualChildThrift')
    if self.numeroProntuario is not None:
      oprot.writeFieldBegin('numeroProntuario', TType.STRING, 1)
      oprot.writeString(self.numeroProntuario)
      oprot.writeFieldEnd()
    if self.cns is not None:
      oprot.writeFieldBegin('cns', TType.STRING, 2)
      oprot.writeString(self.cns)
      oprot.writeFieldEnd()
    if self.dataNascimento is not None:
      oprot.writeFieldBegin('dataNascimento', TType.I64, 3)
      oprot.writeI64(self.dataNascimento)
      oprot.writeFieldEnd()
    if self.localDeAtendimento is not None:
      oprot.writeFieldBegin('localDeAtendimento', TType.I64, 4)
      oprot.writeI64(self.localDeAtendimento)
      oprot.writeFieldEnd()
    if self.sexo is not None:
      oprot.writeFieldBegin('sexo', TType.I64, 5)
      oprot.writeI64(self.sexo)
      oprot.writeFieldEnd()
    if self.turno is not None:
      oprot.writeFieldBegin('turno', TType.I64, 6)
      oprot.writeI64(self.turno)
      oprot.writeFieldEnd()
    if self.tipoAtendimento is not None:
      oprot.writeFieldBegin('tipoAtendimento', TType.I64, 7)
      oprot.writeI64(self.tipoAtendimento)
      oprot.writeFieldEnd()
    if self.pesoAcompanhamentoNutricional is not None:
      oprot.writeFieldBegin('pesoAcompanhamentoNutricional', TType.DOUBLE, 8)
      oprot.writeDouble(self.pesoAcompanhamentoNutricional)
      oprot.writeFieldEnd()
    if self.alturaAcompanhamentoNutricional is not None:
      oprot.writeFieldBegin('alturaAcompanhamentoNutricional', TType.DOUBLE, 9)
      oprot.writeDouble(self.alturaAcompanhamentoNutricional)
      oprot.writeFieldEnd()
    if self.aleitamentoMaterno is not None:
      oprot.writeFieldBegin('aleitamentoMaterno', TType.I64, 10)
      oprot.writeI64(self.aleitamentoMaterno)
      oprot.writeFieldEnd()
    if self.dumDaGestante is not None:
      oprot.writeFieldBegin('dumDaGestante', TType.I64, 11)
      oprot.writeI64(self.dumDaGestante)
      oprot.writeFieldEnd()
    if self.idadeGestacional is not None:
      oprot.writeFieldBegin('idadeGestacional', TType.I32, 12)
      oprot.writeI32(self.idadeGestacional)
      oprot.writeFieldEnd()
    if self.atencaoDomiciliarModalidade is not None:
      oprot.writeFieldBegin('atencaoDomiciliarModalidade', TType.I64, 13)
      oprot.writeI64(self.atencaoDomiciliarModalidade)
      oprot.writeFieldEnd()
    if self.problemaCondicaoAvaliada is not None:
      oprot.writeFieldBegin('problemaCondicaoAvaliada', TType.STRUCT, 14)
      self.problemaCondicaoAvaliada.write(oprot)
      oprot.writeFieldEnd()
    if self.exame is not None:
      oprot.writeFieldBegin('exame', TType.LIST, 17)
      oprot.writeListBegin(TType.STRUCT, len(self.exame))
      for iter50 in self.exame:
        iter50.write(oprot)
      oprot.writeListEnd()
      oprot.writeFieldEnd()
    if self.vacinaEmDia is not None:
      oprot.writeFieldBegin('vacinaEmDia', TType.BOOL, 18)
      oprot.writeBool(self.vacinaEmDia)
      oprot.writeFieldEnd()
    if self.pic is not None:
      oprot.writeFieldBegin('pic', TType.I64, 19)
      oprot.writeI64(self.pic)
      oprot.writeFieldEnd()
    if self.ficouEmObservacao is not None:
      oprot.writeFieldBegin('ficouEmObservacao', TType.BOOL, 20)
      oprot.writeBool(self.ficouEmObservacao)
      oprot.writeFieldEnd()
    if self.nasfs is not None:
      oprot.writeFieldBegin('nasfs', TType.LIST, 21)
      oprot.writeListBegin(TType.I64, len(self.nasfs))
      for iter51 in self.nasfs:
        oprot.writeI64(iter51)
      oprot.writeListEnd()
      oprot.writeFieldEnd()
    if self.condutas is not None:
      oprot.writeFieldBegin('condutas', TType.LIST, 22)
      oprot.writeListBegin(TType.I64, len(self.condutas))
      for iter52 in self.condutas:
        oprot.writeI64(iter52)
      oprot.writeListEnd()
      oprot.writeFieldEnd()
    if self.stGravidezPlanejada is not None:
      oprot.writeFieldBegin('stGravidezPlanejada', TType.BOOL, 23)
      oprot.writeBool(self.stGravidezPlanejada)
      oprot.writeFieldEnd()
    if self.nuGestasPrevias is not None:
      oprot.writeFieldBegin('nuGestasPrevias', TType.I32, 24)
      oprot.writeI32(self.nuGestasPrevias)
      oprot.writeFieldEnd()
    if self.nuPartos is not None:
      oprot.writeFieldBegin('nuPartos', TType.I32, 25)
      oprot.writeI32(self.nuPartos)
      oprot.writeFieldEnd()
    if self.racionalidadeSaude is not None:
      oprot.writeFieldBegin('racionalidadeSaude', TType.I64, 26)
      oprot.writeI64(self.racionalidadeSaude)
      oprot.writeFieldEnd()
    if self.perimetroCefalico is not None:
      oprot.writeFieldBegin('perimetroCefalico', TType.DOUBLE, 27)
      oprot.writeDouble(self.perimetroCefalico)
      oprot.writeFieldEnd()
    if self.dataHoraInicialAtendimento is not None:
      oprot.writeFieldBegin('dataHoraInicialAtendimento', TType.I64, 28)
      oprot.writeI64(self.dataHoraInicialAtendimento)
      oprot.writeFieldEnd()
    if self.dataHoraFinalAtendimento is not None:
      oprot.writeFieldBegin('dataHoraFinalAtendimento', TType.I64, 29)
      oprot.writeI64(self.dataHoraFinalAtendimento)
      oprot.writeFieldEnd()
    if self.cpfCidadao is not None:
      oprot.writeFieldBegin('cpfCidadao', TType.STRING, 30)
      oprot.writeString(self.cpfCidadao)
      oprot.writeFieldEnd()
    if self.medicamentos is not None:
      oprot.writeFieldBegin('medicamentos', TType.LIST, 31)
      oprot.writeListBegin(TType.STRUCT, len(self.medicamentos))
      for iter53 in self.medicamentos:
        iter53.write(oprot)
      oprot.writeListEnd()
      oprot.writeFieldEnd()
    if self.encaminhamentos is not None:
      oprot.writeFieldBegin('encaminhamentos', TType.LIST, 32)
      oprot.writeListBegin(TType.STRUCT, len(self.encaminhamentos))
      for iter54 in self.encaminhamentos:
        iter54.write(oprot)
      oprot.writeListEnd()
      oprot.writeFieldEnd()
    if self.resultadosExames is not None:
      oprot.writeFieldBegin('resultadosExames', TType.LIST, 33)
      oprot.writeListBegin(TType.STRUCT, len(self.resultadosExames))
      for iter55 in self.resultadosExames:
        iter55.write(oprot)
      oprot.writeListEnd()
      oprot.writeFieldEnd()
    if self.uuidRnds is not None:
      oprot.writeFieldBegin('uuidRnds', TType.STRING, 34)
      oprot.writeString(self.uuidRnds)
      oprot.writeFieldEnd()
    if self.finalizadorObservacao is not None:
      oprot.writeFieldBegin('finalizadorObservacao', TType.STRUCT, 35)
      self.finalizadorObservacao.write(oprot)
      oprot.writeFieldEnd()
    if self.tipoParticipacaoCidadao is not None:
      oprot.writeFieldBegin('tipoParticipacaoCidadao', TType.I64, 36)
      oprot.writeI64(self.tipoParticipacaoCidadao)
      oprot.writeFieldEnd()
    if self.tipoParticipacaoProfissionalConvidado is not None:
      oprot.writeFieldBegin('tipoParticipacaoProfissionalConvidado', TType.I64, 37)
      oprot.writeI64(self.tipoParticipacaoProfissionalConvidado)
      oprot.writeFieldEnd()
    oprot.writeFieldStop()
    oprot.writeStructEnd()

  def validate(self):
    return


  def __hash__(self):
    value = 17
    value = (value * 31) ^ hash(self.numeroProntuario)
    value = (value * 31) ^ hash(self.cns)
    value = (value * 31) ^ hash(self.dataNascimento)
    value = (value * 31) ^ hash(self.localDeAtendimento)
    value = (value * 31) ^ hash(self.sexo)
    value = (value * 31) ^ hash(self.turno)
    value = (value * 31) ^ hash(self.tipoAtendimento)
    value = (value * 31) ^ hash(self.pesoAcompanhamentoNutricional)
    value = (value * 31) ^ hash(self.alturaAcompanhamentoNutricional)
    value = (value * 31) ^ hash(self.aleitamentoMaterno)
    value = (value * 31) ^ hash(self.dumDaGestante)
    value = (value * 31) ^ hash(self.idadeGestacional)
    value = (value * 31) ^ hash(self.atencaoDomiciliarModalidade)
    value = (value * 31) ^ hash(self.problemaCondicaoAvaliada)
    value = (value * 31) ^ hash(self.exame)
    value = (value * 31) ^ hash(self.vacinaEmDia)
    value = (value * 31) ^ hash(self.pic)
    value = (value * 31) ^ hash(self.ficouEmObservacao)
    value = (value * 31) ^ hash(self.nasfs)
    value = (value * 31) ^ hash(self.condutas)
    value = (value * 31) ^ hash(self.stGravidezPlanejada)
    value = (value * 31) ^ hash(self.nuGestasPrevias)
    value = (value * 31) ^ hash(self.nuPartos)
    value = (value * 31) ^ hash(self.racionalidadeSaude)
    value = (value * 31) ^ hash(self.perimetroCefalico)
    value = (value * 31) ^ hash(self.dataHoraInicialAtendimento)
    value = (value * 31) ^ hash(self.dataHoraFinalAtendimento)
    value = (value * 31) ^ hash(self.cpfCidadao)
    value = (value * 31) ^ hash(self.medicamentos)
    value = (value * 31) ^ hash(self.encaminhamentos)
    value = (value * 31) ^ hash(self.resultadosExames)
    value = (value * 31) ^ hash(self.uuidRnds)
    value = (value * 31) ^ hash(self.finalizadorObservacao)
    value = (value * 31) ^ hash(self.tipoParticipacaoCidadao)
    value = (value * 31) ^ hash(self.tipoParticipacaoProfissionalConvidado)
    return value

  def __repr__(self):
    L = ['%s=%r' % (key, value)
      for key, value in self.__dict__.iteritems()]
    return '%s(%s)' % (self.__class__.__name__, ', '.join(L))

  def __eq__(self, other):
    return isinstance(other, self.__class__) and self.__dict__ == other.__dict__

  def __ne__(self, other):
    return not (self == other)

class FichaAtendimentoIndividualMasterThrift:
  """
  Attributes:
   - headerTransport
   - atendimentosIndividuais
   - uuidFicha
   - tpCdsOrigem
  """

  thrift_spec = (
    None, # 0
    (1, TType.STRUCT, 'headerTransport', (br.gov.saude.esusab.ras.common.ttypes.VariasLotacoesHeaderThrift, br.gov.saude.esusab.ras.common.ttypes.VariasLotacoesHeaderThrift.thrift_spec), None, ), # 1
    (2, TType.LIST, 'atendimentosIndividuais', (TType.STRUCT,(FichaAtendimentoIndividualChildThrift, FichaAtendimentoIndividualChildThrift.thrift_spec)), None, ), # 2
    (3, TType.STRING, 'uuidFicha', None, None, ), # 3
    (4, TType.I32, 'tpCdsOrigem', None, None, ), # 4
  )

  def __init__(self, headerTransport=None, atendimentosIndividuais=None, uuidFicha=None, tpCdsOrigem=None,):
    self.headerTransport = headerTransport
    self.atendimentosIndividuais = atendimentosIndividuais
    self.uuidFicha = uuidFicha
    self.tpCdsOrigem = tpCdsOrigem

  def read(self, iprot):
    if iprot.__class__ == TBinaryProtocol.TBinaryProtocolAccelerated and isinstance(iprot.trans, TTransport.CReadableTransport) and self.thrift_spec is not None and fastbinary is not None:
      fastbinary.decode_binary(self, iprot.trans, (self.__class__, self.thrift_spec))
      return
    iprot.readStructBegin()
    while True:
      (fname, ftype, fid) = iprot.readFieldBegin()
      if ftype == TType.STOP:
        break
      if fid == 1:
        if ftype == TType.STRUCT:
          self.headerTransport = br.gov.saude.esusab.ras.common.ttypes.VariasLotacoesHeaderThrift()
          self.headerTransport.read(iprot)
        else:
          iprot.skip(ftype)
      elif fid == 2:
        if ftype == TType.LIST:
          self.atendimentosIndividuais = []
          (_etype59, _size56) = iprot.readListBegin()
          for _i60 in xrange(_size56):
            _elem61 = FichaAtendimentoIndividualChildThrift()
            _elem61.read(iprot)
            self.atendimentosIndividuais.append(_elem61)
          iprot.readListEnd()
        else:
          iprot.skip(ftype)
      elif fid == 3:
        if ftype == TType.STRING:
          self.uuidFicha = iprot.readString()
        else:
          iprot.skip(ftype)
      elif fid == 4:
        if ftype == TType.I32:
          self.tpCdsOrigem = iprot.readI32()
        else:
          iprot.skip(ftype)
      else:
        iprot.skip(ftype)
      iprot.readFieldEnd()
    iprot.readStructEnd()

  def write(self, oprot):
    if oprot.__class__ == TBinaryProtocol.TBinaryProtocolAccelerated and self.thrift_spec is not None and fastbinary is not None:
      oprot.trans.write(fastbinary.encode_binary(self, (self.__class__, self.thrift_spec)))
      return
    oprot.writeStructBegin('FichaAtendimentoIndividualMasterThrift')
    if self.headerTransport is not None:
      oprot.writeFieldBegin('headerTransport', TType.STRUCT, 1)
      self.headerTransport.write(oprot)
      oprot.writeFieldEnd()
    if self.atendimentosIndividuais is not None:
      oprot.writeFieldBegin('atendimentosIndividuais', TType.LIST, 2)
      oprot.writeListBegin(TType.STRUCT, len(self.atendimentosIndividuais))
      for iter62 in self.atendimentosIndividuais:
        iter62.write(oprot)
      oprot.writeListEnd()
      oprot.writeFieldEnd()
    if self.uuidFicha is not None:
      oprot.writeFieldBegin('uuidFicha', TType.STRING, 3)
      oprot.writeString(self.uuidFicha)
      oprot.writeFieldEnd()
    if self.tpCdsOrigem is not None:
      oprot.writeFieldBegin('tpCdsOrigem', TType.I32, 4)
      oprot.writeI32(self.tpCdsOrigem)
      oprot.writeFieldEnd()
    oprot.writeFieldStop()
    oprot.writeStructEnd()

  def validate(self):
    if self.uuidFicha is None:
      raise TProtocol.TProtocolException(message='Required field uuidFicha is unset!')
    return


  def __hash__(self):
    value = 17
    value = (value * 31) ^ hash(self.headerTransport)
    value = (value * 31) ^ hash(self.atendimentosIndividuais)
    value = (value * 31) ^ hash(self.uuidFicha)
    value = (value * 31) ^ hash(self.tpCdsOrigem)
    return value

  def __repr__(self):
    L = ['%s=%r' % (key, value)
      for key, value in self.__dict__.iteritems()]
    return '%s(%s)' % (self.__class__.__name__, ', '.join(L))

  def __eq__(self, other):
    return isinstance(other, self.__class__) and self.__dict__ == other.__dict__

  def __ne__(self, other):
    return not (self == other)
